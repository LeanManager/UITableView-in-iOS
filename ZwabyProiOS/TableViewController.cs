using Foundation;
using System;
using UIKit;
using CoreGraphics;

namespace ZwabyProiOS
{
    public partial class TableViewController : UITableViewController
    {
        EmailServer emailServer = new EmailServer();

        public TableViewController (IntPtr handle) : base (handle)
        {
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return emailServer.Emails.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = new UITableViewCell(CGRect.Empty);

            var emailItem = emailServer.Emails[indexPath.Row];

            cell.TextLabel.Text = emailItem.Subject;

            return cell;
        }
    }
}