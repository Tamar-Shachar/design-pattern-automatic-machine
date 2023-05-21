using OODProject.Decoretor;
using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;
internal class Warp : BaseHandler
{
    private ManualResetEvent mre = new ManualResetEvent(false);
    public override async Task<IItem> Handel(IItem item)
    {
        if (MessageBox.
            Show("do you want a gift wrap?", "Gift Wrap",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            item = new GiftWarp(item);
        }
        #region 😕
        /*
        Form form1 = Application.OpenForms["Form1"];
        Button Btn1 = new Button();
        form1.Controls.Add(Btn1);
        Btn1.Text = "I want gift wrap";
        Btn1.Size = new Size(100, 100);
        Btn1.Location = new Point(420, 400);
        
        Btn1.Click += async(sender, e) =>
        {
            item = new GiftWarp(item); 
            mre.Set();
        };

        Button Btn2 = new Button();
        form1.Controls.Add(Btn2);
        Btn2.Text = "I don't want gift wrap";
        Btn2.Size = new Size(100, 100);
        Btn2.Location = new Point(550, 400);
        Btn2.Click +=async (sender, e) =>
        {
            mre.Set();
        };

        await Task.Run(() =>
        {
            mre.WaitOne();
            mre.Reset();

        });
        */
        #endregion
        return base.Handel(item).Result;
    }
}
