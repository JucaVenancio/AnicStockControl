using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnicStockControl.Data;
using AnicStockControl.Entities;


namespace AnicStockControl.Screens
{
    public partial class UserScreen : Form
    {
         

        public UserScreen(User user)
        {
            User user2 = user;
            UsernameToolStrip.Text = user.Firstname;//+ " " + this.user.Lastname;
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            using(AnicStockControlContext context = new AnicStockControlContext())
            {
                int CountItem = context.Items.Count();
                
                Item[] items = new Item[CountItem];
                for(int i = 0; i < CountItem; i++)
                {
                    items[i] = context.Items.ElementAt(i);
                }
            }
        }
    }
}
