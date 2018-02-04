using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace ZwabyProiOS
{
    public class EmailServerSource : UITableViewSource
    {
        EmailServer emailServer = new EmailServer();

        public override nint RowsInSection(UITableView tableview, nint section)
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
