using OODProject.Decorator;
using OODProject.Factory;
using OODProject.Observer;
using OODProject.Singleton;
using OODProject.TamplateMethod;

namespace OODProject;


public partial class Form1 : Form
{
    public ManualResetEvent mre { get; }= new ManualResetEvent(false);
    public Form1()
    {
        InitializeComponent();
        SuplierA suplierA = new SuplierA();
        Bisli.Attach(suplierA);
        SuplierB suplierB = new SuplierB();
        Orange.Attach(suplierB);


        /* End of day:*/
          TaskSchedulerA.Instance.ScheduleTask(00, 00, 00,
             () => { reportTxtSaver.WriteReport(); });
        /*TaskSchedulerA.Instance.ScheduleTask(DateTime.Now.Hour, DateTime.Now.Second + 1, 00,
            () => { reportTxtSaver.WriteReport(); });*/
    }
    ReportTxtSaver reportTxtSaver = new ReportTxtSaver();
    AutomaticMachine machine;
    string[] snackArr = { nameof(Bisli), nameof(Chips), nameof(Bamba) };
    string[] hotDrinkArr = { nameof(Coffee), nameof(Shoko), nameof(Tea), nameof(Sugar), nameof(HotWatter), nameof(Milk) };
    string[] drinkArr = { nameof(Orange), nameof(Soda), nameof(Cola) };
    Button hotDrink = new Button();
    Button snack = new Button();
    Button drink = new Button();
    Button pay = new Button();
    
    private void StartShoppingBtn_Click(object sender, EventArgs e)
    {
        machine = new AutomaticMachine();
        Shop();
        
    }
    private void Shop()
    {
        string type = "";
        string product = "";
        List<string> ingredients = new List<string>();
        //this.Controls.Remove(StartShoppingBtn);
        StartShoppingBtn.Hide();
        #region create buttons

        this.Controls.Add(snack);
        snack.Text = "Snack\nChoose snack that you like:";
        snack.Location = new Point(672, 160);
        snack.Size = new Size(200, 70);
        snack.Click += (sender, e) =>
        {
            foreach (string item in drinkArr)
            {
                this.Controls[item].Enabled = false;
            }
            foreach (string item in snackArr)
            {
                this.Controls[item].Enabled = true;
            }
            foreach (string item in hotDrinkArr)
            {
                this.Controls[item].Enabled = false;
            }
            drink.Enabled = true;
            snack.Enabled = false;
            hotDrink.Enabled = true;
        };


        this.Controls.Add(drink);
        drink.Text = "Drink\nChoose your favorite drink:";
        drink.Location = new Point(232, 160);
        drink.Size = new Size(200, 70);
        drink.Click += (sender, e) =>
        {
            foreach (string item in drinkArr)
            {
                this.Controls[item].Enabled = true;
            }
            foreach (string item in snackArr)
            {
                this.Controls[item].Enabled = false;
            }
            foreach (string item in hotDrinkArr)
            {
                this.Controls[item].Enabled = false;
            }
           
            drink.Enabled = false;
            snack.Enabled = true;
            hotDrink.Enabled = true;
        };

        this.Controls.Add(hotDrink);
        hotDrink.Text = "Hot Drink\nPrepare you hot cup:";
        hotDrink.Location = new Point(452, 160);
        hotDrink.Size = new Size(200, 70);
        hotDrink.Click += (sender, e) =>
        {
            
            foreach (string item in drinkArr)
            {
                this.Controls[item].Enabled = false;
            }
            foreach (string item in snackArr)
            {
                this.Controls[item].Enabled = false;
            }
            foreach (string item in hotDrinkArr)
            {
                this.Controls[item].Enabled = true;
            }
            
            drink.Enabled = true;
            snack.Enabled = true;
            hotDrink.Enabled = false;
            
            ingredients.RemoveRange(0, ingredients.Count);
        };

        for (int i = 0; i < snackArr.Length; i++)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Name = snackArr[i];
            btn.Text = snackArr[i];
            btn.Size = new Size(150, 50);
            btn.Location = new Point(697, 180 + (i + 1) * 60);
            btn.Click += (sender, e) =>
            {
                type = "Snack";
                product = btn.Name;
                pay.Enabled = true;
            };
            btn.Enabled = false;
        }
        for (int i = 0; i < hotDrinkArr.Length; i++)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Name = hotDrinkArr[i];
            btn.Text = hotDrinkArr[i];
            btn.Size = new Size(150, 50);
            btn.Location = new Point(477, 180 + (i + 1) * 60);
            btn.Click += (sender, e) =>
            {
                type = "HotDrink";
                ingredients.Add(btn.Name);
                pay.Enabled = true;
            };
            btn.Enabled = false;
        }


        for (int i = 0; i < drinkArr.Length; i++)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Name = drinkArr[i];
            btn.Text = drinkArr[i];
            btn.Size = new Size(150, 50);
            btn.Location = new Point(257, 180 + (i + 1) * 60);
            btn.Click += (sender, e) =>
            {
                type = "Drink";
                product = btn.Name;
                pay.Enabled = true;
            };
            btn.Enabled = false;
        }

        this.Controls.Add(pay);
        pay.Text = "Go To Payment";
        pay.Location = new Point(232, 250 + GetMaxLen() * 60);
        pay.Size = new Size(640, 50);
        pay.Click += (sender, e) =>
        {
            if (type.Equals("HotDrink"))
            {
                Payment(type, ingredients.ToArray());
            }
            Payment(type, product);
            this.Controls.Remove(pay);
        };
        pay.Enabled = false;
        #endregion

    }
    private void Payment(string t, params string[] p)
    {
        
        foreach (var item in snackArr)
        {
            this.Controls.RemoveByKey(item);
        }
        foreach (var item in drinkArr)
        {
            this.Controls.RemoveByKey(item);
        }
        foreach (var item in hotDrinkArr)
        {
            this.Controls.RemoveByKey(item);
        }
        this.Controls.Remove(snack);
        this.Controls.Remove(drink);
        this.Controls.Remove(hotDrink);
        this.Controls.Remove(pay);
        machine.StartShpping(t, p);
    }
    private int GetMaxLen()
    {
        if (snackArr.Length > drinkArr.Length)
        {
            if (snackArr.Length > hotDrinkArr.Length)
            {
                return snackArr.Length;
            }
        }
        return drinkArr.Length > hotDrinkArr.Length ?
            drinkArr.Length :
            hotDrinkArr.Length;
    }

}

