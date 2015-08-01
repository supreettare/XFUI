using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFormsUI.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(ViewCell), typeof(MyViewCellRenderer))]

namespace XFormsUI.iOS.CustomRenderer
{
    public class MyViewCellRenderer : ViewCellRenderer
    {
        private class LongPressGestureRecognizer : UILongPressGestureRecognizer
        {
            private WeakReference<UITableView> TableView { get; set; }

            private WeakReference<ViewCell> ViewCell { get; set; }

            private NSIndexPath sourceIndexPath, destinationIndexPath;

            public static LongPressGestureRecognizer CreateGesture(UITableView tableView, ViewCell cell)
            {
                return new LongPressGestureRecognizer(OnRecognizing)
                {
                    TableView = new WeakReference<UITableView>(tableView),
                    ViewCell = new WeakReference<ViewCell>(cell),
                };
            }

            private static void OnRecognizing(UILongPressGestureRecognizer r)
            {
                LongPressGestureRecognizer recognizer = r as LongPressGestureRecognizer;
                UITableView tableView;
                recognizer.TableView.TryGetTarget(out tableView);
                ViewCell cell;
                recognizer.ViewCell.TryGetTarget(out cell);
                if (tableView == null || cell == null)
                {
                    return;
                }
                OnRecognizing(recognizer, tableView, cell);
            }

            private static void OnRecognizing(LongPressGestureRecognizer recognizer, UITableView tableView, ViewCell cell)
            {
                NSIndexPath indexPath = tableView.IndexPathForRowAtPoint(recognizer.LocationInView(tableView));
                switch (recognizer.State)
                {
                    case UIGestureRecognizerState.Began:
                        if (indexPath != null)
                        {
                            // Remember the source row
                            recognizer.sourceIndexPath = indexPath;
                            recognizer.destinationIndexPath = indexPath;
                            cell.View.BackgroundColor = Color.Gray;
                        }
                        break;
                    case UIGestureRecognizerState.Changed:
                        if (recognizer.destinationIndexPath != null && indexPath != null && recognizer.destinationIndexPath != indexPath)
                        {
                            // Dragged to a new row location, so show it to the user with animation
                            tableView.MoveRow(recognizer.destinationIndexPath, indexPath);
                            recognizer.destinationIndexPath = indexPath;
                        }
                        break;
                    case UIGestureRecognizerState.Cancelled:
                    case UIGestureRecognizerState.Failed:
                        recognizer.sourceIndexPath = null;
                        cell.View.BackgroundColor = Color.Transparent;
                        break;
                    case UIGestureRecognizerState.Recognized:
                        // Move the data source finally
                        if (recognizer.sourceIndexPath != null && recognizer.destinationIndexPath != null && recognizer.sourceIndexPath != recognizer.destinationIndexPath)
                        {
                            // Reset the move because otherwise the underneath control will get out of sync with
                            // the Xamarin.Forms element. The next line will drive the real change from ItemsSource
                            tableView.MoveRow(recognizer.destinationIndexPath, recognizer.sourceIndexPath);
                            tableView.Source.MoveRow(tableView, recognizer.sourceIndexPath, recognizer.destinationIndexPath);
                        }
                        recognizer.sourceIndexPath = null;
                        recognizer.destinationIndexPath = null;
                        cell.View.BackgroundColor = Color.Transparent;
                        break;
                }
            }

            private LongPressGestureRecognizer(Action<UILongPressGestureRecognizer> action)
                : base(action)
            {
            }
        }

        public override UITableViewCell GetCell(Cell item, UITableViewCell reusedCell, UITableView tableView)
        {
            UITableViewCell tableViewCell = base.GetCell(item, reusedCell, tableView);
            AddGestures(item as ViewCell, tableViewCell, tableView);
            return tableViewCell;
        }

        private void AddGestures(ViewCell cell, UITableViewCell tableViewCell, UITableView tableView)
        {
            tableViewCell.AddGestureRecognizer(LongPressGestureRecognizer.CreateGesture(tableView, cell));
        }
    }
}