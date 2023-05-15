using OODProject.Decoretor;
using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;

internal class Packing : BaseHandler
{
    public override async Task<IItem> Handel(IItem item)
    {
        Form form1 = Application.OpenForms["Form1"];
        Button Btn1 = new Button();
        Btn1.Text = "I want bag";
        Btn1.Size = new Size(100, 100);
        Btn1.Location = new Point(420, 600);
        form1.Controls.Add(Btn1);
        Btn1.Click += (sender, e) =>
        {
            item = new Bag(item);

        };

        Button Btn2 = new Button();
        Btn2.Text = "I don't want bag";
        Btn2.Size = new Size(100, 100);
        Btn2.Location = new Point(550, 600);
        form1.Controls.Add(Btn2);

        using (SemaphoreSlim semaphore = new SemaphoreSlim(0, 1))
        {
            void OnClick(object sender, EventArgs e) => semaphore.Release();
            Btn1.Click += OnClick;
            await semaphore.WaitAsync();
            Btn1.Click -= OnClick;
        }

        return base.Handel(item).Result;
    }
}
