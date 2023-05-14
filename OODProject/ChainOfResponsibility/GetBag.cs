using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal class GetBag : BaseHandler
{
    public override IItem Handel(IItem item)
    {

        if (item != null)
        {
           /* Form form1 = Application.OpenForms["Form1"];
            Button Btn1 = new Button();
            Btn1.Text = "I want bag";
            Btn1.Size = new Size(100, 100);
            Btn1.Location = new Point(500, 600);
            form1.Controls.Add(Btn1);

            Button Btn2 = new Button();
            Btn2.Text = "I don't want bag";
            Btn2.Size = new Size(100, 100);
            Btn2.Location = new Point(600, 800);
            form1.Controls.Add(Btn2);*/
            return base.Handel(item);
        }
        return null;
    }
}
