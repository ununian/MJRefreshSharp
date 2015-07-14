using System;
using System.Drawing;

using Foundation;
using UIKit;
using CoreGraphics;
using System.Collections.Generic;
using System.Linq;
using MJRefresh;
using ObjCRuntime;
using System.Threading.Tasks;

namespace MJRefresSharpDemo
{
    public partial class MJRefresSharpDemoViewController : UIViewController
    {
        public MJRefresSharpDemoViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();
			
            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        UITableView TableView;
        TableSource Source;

        Random r = new Random();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView = new UITableView(new CGRect(0, 20, View.Frame.Width, View.Frame.Height - 30));
            string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            Source = new TableSource(tableItems, TableView); 
            this.TableView.Source = Source;
            // Perform any additional setup after loading the view, typically from a nib.
            
            View.AddSubview(TableView);

            var addBtn = new UIButton(new CGRect(20, 100, 100, 44));
            addBtn.SetTitle("Add", UIControlState.Normal);
            addBtn.SetTitleColor(UIColor.Orange, UIControlState.Normal);
            addBtn.TouchUpInside += (s, e) =>
            {
                Source.Add("TestData : " + r.Next(1000, 10000));    
            };

            View.AddSubview(addBtn);

            var header = new MJRefreshNormalHeader();
            TableView.SetHeader(header);

            header.RefreshingBlock = async () =>
            { 
                Source.Add("TestData : " + r.Next(1000, 10000));    
                await Task.Delay(1000);
                header.EndRefreshing();
            };
            
            header.SetTitle("AA", MJRefreshState.Idle);
            header.SetTitle("BB", MJRefreshState.Pulling);
            header.SetTitle("CC", MJRefreshState.Refreshing);
            header.LastUpdatedTimeLabel.Hidden = true;
        }

        public void LoadData()
        {
          
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        #endregion
    }

    public class TableSource : UITableViewSource
    {
        List<string> tableItems;
        UITableView View;
        string cellIdentifier = "TableCell";

        public TableSource(string[] items, UITableView view)
        {
            tableItems = items.ToList();
            View = view;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tableItems.Count;
        }

        public void Add(string str)
        {
            tableItems.Add(str);
            View.InsertRows(new NSIndexPath[]{ NSIndexPath.FromRowSection(tableItems.Count - 1, 0) }, UITableViewRowAnimation.Left);
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            // if there are no cells to reuse, create a new one
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;
        }
    }
}

