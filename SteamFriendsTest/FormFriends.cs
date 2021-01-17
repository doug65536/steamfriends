using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmFriends : Form
    {
        public frmFriends()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string fetchPage(string url)
        {
            try
            {
                WebRequest req = WebRequest.Create(tbUrl.Text);
                WebResponse res = req.GetResponse();
                using (StreamReader sr = new StreamReader(res.GetResponseStream()))
                {
                    return sr.ReadToEnd();
                }
                
            }
            catch (Exception ex)
            {
                Debug.Print("Internet error: " + ex.Message);
                return null;
            }
        }

        private string[] GetFriendsFromFriendPage(string url)
        {
            string page = fetchPage(url);

            // It is inappropriate to use regular expressions to parse HTML
            // but this is just a quick and dirty implementation
            Regex reElements = new Regex("<div\\s+class=\"friend_block_content\">([^<]+)<");
            MatchCollection matches = reElements.Matches(page);

            var result = new List<string>(matches.Count);
            foreach (Match match in matches)
            {
                var matchString = match.Groups[1].Value;
                
                // At least we properly parse HTML text here
                result.Add(HttpUtility.HtmlDecode(matchString));
            }

            return result.ToArray<string>();
        }

        private void UpdateFriends()
        {
            var friends = GetFriendsFromFriendPage(tbUrl.Text);
            lstFriends.Items.Clear();

            foreach (var friend in friends)
                lstFriends.Items.Add(friend);
        }

        private void butFetch_Click(object sender, EventArgs e)
        {
            UpdateFriends();
        }

        private void tbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\n')
                UpdateFriends();
        }
    }
}
