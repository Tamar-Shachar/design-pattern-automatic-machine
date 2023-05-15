using OODProject.Decoretor;
using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal class Warp : BaseHandler
{

    public override async Task<IItem> Handel(IItem item)
    {
        Form form1 = Application.OpenForms["Form1"];

        
        Button Btn1 = new Button();
        Btn1.Text = "I want gift wrap";
        Btn1.Size = new Size(100, 100);
        Btn1.Location = new Point(420, 400);
        form1.Controls.Add(Btn1);
        Btn1.Click += (sender, e) =>
        {
            item = new GiftWarp(item);
        };

        Button Btn2 = new Button();
        Btn2.Text = "I don't want gift wrap";
        Btn2.Size = new Size(100, 100);
        Btn2.Location = new Point(550, 400);
        form1.Controls.Add(Btn2);

        await Task.Delay(5000);
        return base.Handel(item).Result;
    }
}
