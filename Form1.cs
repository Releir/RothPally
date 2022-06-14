using RothPally.Helper;
using System.Diagnostics;

namespace RothPally
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button.CheckForIllegalCrossThreadCalls = false;
            CheckBox.CheckForIllegalCrossThreadCalls = false;
            Label.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static int hpVal = 0;
        static int hpMax = 0;

        private async void MemoryReader(Process actualProcess, CancellationToken token)
        {
            IntPtr proc = actualProcess.Handle;
            int hpAddr = 0x010DCE10;  //New Era Addr
            int hpMaxAddr = hpAddr + 4;

            while (!token.IsCancellationRequested)
            {
                int hpVal = Util.ReadInt32(proc, hpAddr);
                int hpMax = Util.ReadInt32(proc, hpMaxAddr);
                await Task.Delay(11);
            }
        }

        private async void AutoPots(Process actualProcess, CancellationToken token)
        {
            IntPtr proc = actualProcess.Handle;
            int hpAddr = 0x010DCE10;  //New Era Addr
            int hpMaxAddr = hpAddr + 4;

            double hpPercToPot = Convert.ToDouble(hpPerc.Text);

            while (!token.IsCancellationRequested)
            {
                int hpVal = Util.ReadInt32(proc, hpAddr);
                int hpMax = Util.ReadInt32(proc, hpMaxAddr);

                double hpPerc = ((double)hpVal / (double)hpMax) * 100;

                Keys hpHotkey = (Keys)Enum.Parse(typeof(Keys), hpKey.Text);

                if (hpPerc < hpPercToPot)
                {
                    Util.postKey(actualProcess, hpHotkey);
                }
                await Task.Delay(1);
            }
        }

        private async void AutoPots2(Process actualProcess, CancellationToken token)
        {
            IntPtr proc = actualProcess.Handle;
            int hp2Addr = 0x010DCE10;  //New Era Addr
            int hp2MaxAddr = hp2Addr + 4;

            double hpPercToPot = Convert.ToDouble(hp2Perc.Text);

            while (!token.IsCancellationRequested)
            {
                int hp2Val = Util.ReadInt32(proc, hp2Addr);
                int hp2Max = Util.ReadInt32(proc, hp2MaxAddr);

                double hp2Perc = ((double)hp2Val / (double)hp2Max) * 100;

                Keys hp2Hotkey = (Keys)Enum.Parse(typeof(Keys), hp2Key.Text);

                if (hp2Perc < hpPercToPot)
                {
                    Util.postKey(actualProcess, hp2Hotkey);
                }
                await Task.Delay(1);
            }
        }

        private async void AutoPots3(Process actualProcess, CancellationToken token)
        {
            IntPtr proc = actualProcess.Handle;
            int hp3Addr = 0x010DCE10;  //New Era Addr
            int hp3MaxAddr = hp3Addr + 4;

            double hp3PercToPot = Convert.ToDouble(hp3Perc.Text);

            while (!token.IsCancellationRequested)
            {
                int hp3Val = Util.ReadInt32(proc, hp3Addr);
                int hp3Max = Util.ReadInt32(proc, hp3MaxAddr);

                double hp3Perc = ((double)hp3Val / (double)hp3Max) * 100;

                Keys hp3Hotkey = (Keys)Enum.Parse(typeof(Keys), hp3Key.Text);

                if (hp3Perc < hp3PercToPot)
                {
                    Util.postKey(actualProcess, hp3Hotkey);
                }
                await Task.Delay(1);
            }
        }

        private async void AutoMana(Process actualProcess, CancellationToken token)
        {
            IntPtr proc = actualProcess.Handle;
            int hpAddr = 0x010DCE10;  //New Era Addr
            int spAddr = hpAddr + 8;
            int spMaxAddr = hpAddr + 12;

            double spPercToPot = Convert.ToDouble(spPerc.Text);

            while (!token.IsCancellationRequested)
            {
                int spVal = Util.ReadInt32(proc, spAddr);
                int spMax = Util.ReadInt32(proc, spMaxAddr);

                double spPerc = ((double)spVal / (double)spMax) * 100;
                Keys spHotkey = (Keys)Enum.Parse(typeof(Keys), spKey.Text);


                if (spPerc < spPercToPot)
                {
                    Util.postKey(actualProcess, spHotkey);
                }
                await Task.Delay(1);
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        CancellationTokenSource src = new CancellationTokenSource();
        Process[] initialProcs = Process.GetProcessesByName("ProcessName Here");
        private async void startBtn_Click(object sender, EventArgs e)
        {
            startBtn.Enabled = false;
            src = new CancellationTokenSource();
            CancellationToken ct = src.Token;
            var tasks = new List<Task>();

            var longOpReader = Task.Factory.StartNew(() => MemoryReader(initialProcs[0], ct), ct, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            var longOp1 = Task.Factory.StartNew(() => AutoPots(initialProcs[0], ct), ct, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            var longOp2 = Task.Factory.StartNew(() => AutoMana(initialProcs[0], ct), ct, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            var longOp3 = Task.Factory.StartNew(() => AutoPots2(initialProcs[0], ct), ct, TaskCreationOptions.LongRunning, TaskScheduler.Default);
            var longOp4 = Task.Factory.StartNew(() => AutoPots3(initialProcs[0], ct), ct, TaskCreationOptions.LongRunning, TaskScheduler.Default);

            tasks.Add(longOp1);
            tasks.Add(longOp2);
            if (hp2Enabled.Checked)
            {
                tasks.Add(longOp3);
            }
            if (hp3Enabled.Checked)
            {
                tasks.Add(longOp4);
            }

            await Task.WhenAll(tasks);
            //await Task.WhenAll(new[] { longOp1, longOp2, longOp3});

        }

        private async void stopBtn_Click(object sender, EventArgs e)
        {
            try
            {
                startBtn.Enabled = true;
                src.Cancel();
            }
            catch (Exception exce)
            {

            }
        }

        private void attachBtn_Click(object sender, EventArgs e)
        {
            initialProcs = Process.GetProcessesByName("Process Name Here");
            procLabel.Text = initialProcs[0].Id.ToString();

        }
    }
}