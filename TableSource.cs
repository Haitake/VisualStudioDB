using System;
using UIKit;
using System.Collections.Generic;
using Foundation;

namespace VisualStudioDB
{
    public class TableSource : UITableViewSource
    {
        List<String> TableItems;
        string CellIdentifier = "Cell";
        public TableSource(List<String> people)
        {
            TableItems = people;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems.Count;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = TableItems[indexPath.Row];
            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            }
            cell.TextLabel.Text = item;
            return cell;

        }
    }
}
