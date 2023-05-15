using OODProject.Factory;
using OODProject.Observer;

namespace OODProject.ChainOfResponsibility;
internal class Payment : BaseHandler
{
    public override async Task<IItem> Handel(IItem item)
    {
        double price = ((Product)item).GetPrice();
        Form form1 = Application.OpenForms["Form1"];
        //ManualResetEvent mre = new(false);
        Label label = new Label();
        label.Text = $"The amount to be paid is: {price}₪";
        label.Size = new Size(800, 50);
        label.Location = new Point(420, 128);
        label.Font = new Font("Arial", 16, FontStyle.Bold);
        form1.Controls.Add(label);

        TextBox amount = new TextBox();
        amount.PlaceholderText = "Enter amount";
        amount.Size = new Size(100, 60);
        amount.Location = new Point(420, 200);
        amount.Font = new Font("Arial", 12);
        form1.Controls.Add(amount);
        form1.ActiveControl = null;

        Button okButton = new Button();
        okButton.Text = "OK";
        okButton.Size = new Size(100, 30);
        okButton.Location = new Point(530, 200);
        form1.Controls.Add(okButton);
        Label label2 = new Label();
        okButton.Click += (sender, e) =>
        {
            label2.Text = $"surplus: {(Int32.Parse(amount.Text)) - price}₪";
            label2.Size = new Size(800, 50);
            label2.Location = new Point(420, 280);
            label2.Font = new Font("Arial", 12);
            form1.Controls.Add(label2);

            label.Enabled = false;
            amount.Enabled = false;
            okButton.Enabled = false;
        };

        using (SemaphoreSlim semaphore = new SemaphoreSlim(0, 1))
        {
            void OnClick(object sender, EventArgs e) => semaphore.Release(1);
            okButton.Click += OnClick;
            await semaphore.WaitAsync();
            okButton.Click -= OnClick;
        }
        return base.Handel(item).Result;
    }


}

