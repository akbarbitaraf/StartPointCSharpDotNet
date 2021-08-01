using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartPointCSharpDotNetWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "https://icon-icons.com/downloadimage.php?id=153761&root=2569/ICO/512/&file=group_highlight_people_icon_153761.ico";
            textBox2.Text = "test number two ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                WebRequest req = WebRequest.Create(textBox1.Text);

                WebResponse res = req.GetResponse();

                Stream imgStream = res.GetResponseStream();

                Image img1 = Image.FromStream(imgStream);
                imgStream.Close();
                pictureBox1.Image = img1;
                samianNotify.Image = img1;
                samianNotify.AppLogoImage = img1;
                //samianNotify.Duration = DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.Long;
                //samianNotify.Header = "تست شماره 2";
                samianNotify.Body = textBox2.Text ?? "متن ارسالی خالی می باشد";
                samianNotify.ID = "545421558";
                samianNotify.Header = "";

                samianNotify.Template = DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText02;
                toastNotificationsManager1.Notifications.Add(samianNotify);
                toastNotificationsManager1.ApplicationId = "imaster";
                toastNotificationsManager1.ApplicationName = "";

                toastNotificationsManager1.ShowNotification(samianNotify.ID);
            }
        }
    }
}
