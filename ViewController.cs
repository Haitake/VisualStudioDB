using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace VisualStudioDB
{
    public partial class ViewController : UIViewController
    {
        const string tableCell = "Cell";
        DBHelper dBHelper = new DBHelper("my.db");
        

        public ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            List<Person> people = dBHelper.Read();
            List<String> stringPerson = new List<String>();
            foreach(var p in people)
            {
                StringPerson stringPerson1 = new StringPerson(p);
                string pom = String.Format("Name: {0}, Age: {1}", p.name, p.age.ToString());
                stringPerson.Add(pom);


            }
            tableView = new UITableView(View.Bounds);
            tableView.Source = new TableSource(stringPerson);
            Add(tableView);
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}