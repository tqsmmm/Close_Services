using Microsoft.Win32;
using System.Windows.Forms;
using System.ServiceProcess;
using System;
using System.Linq;

namespace SystemServices
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 修改服务注册表
        /// </summary>
        /// <param name="serviceName">服务名</param>
        /// <param name="key">键</param>
        /// <param name="val">值</param>
        //public void SetRegVal(string serviceName, string key, string val)
        //{
        //    GF_RegReadWrite.SetRegVal(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default), @"SYSTEM\CurrentControlSet\services\" + serviceName, key, val);
        //}

        private void Switch_Service(string Name, bool Status)
        {
            var serviceControllers = ServiceController.GetServices();
            //Start为启动类型
            //4为禁用服务，3为手动启动，2为自动，1为自动延迟
            //2345PicSvc为服务名
            //SetRegVal("2345PicSvc", "Start", "4");

            //获取指定服务，若服务状态不是Runing就Start该服务
            var server = serviceControllers.FirstOrDefault(service => service.ServiceName == Name);

            if (Status)
            {
                if (server != null && server.Status != ServiceControllerStatus.Running)
                {
                    //启动服务
                    server.Start();
                }
            }
            else
            {
                if (server!=null && server.Status!= ServiceControllerStatus.Stopped)
                {
                    //停止服务
                    server.Stop();
                }
            }
        }

        private void Load_Service()
        {
            //获得服务集合
            var serviceControllers = ServiceController.GetServices();

            //遍历服务集合，打印服务名和服务状态
            foreach (var service in serviceControllers)
            {
                if (service.Status == ServiceControllerStatus.Running)
                {
                    checkedListBox1.Items.Add(service.ServiceName);
                }
                else
                {
                    checkedListBox2.Items.Add(service.ServiceName);
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Hide();
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.Yes)
            {
                Show();
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                if (rbnCount.Checked)
                {
                    tmrHours.Interval = Convert.ToInt32(3600000 * nudHours.Value);
                    tmrHours.Enabled = true;
                }
                else if (rbnDate.Checked)
                {
                    tmrDate.Interval = 1000;
                    tmrDate.Enabled = true;
                }

                btnStart.Text = "Stop";
            }
            else
            {
                tmrHours.Enabled = false;

                btnStart.Text = "Start";
            }
        }

        private void tmrHours_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                Switch_Service(checkedListBox1.CheckedItems[i].ToString(), false);
            }

            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                Switch_Service(checkedListBox2.CheckedItems[i].ToString(), true);
            }

            Load_Service();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Hide();

            Load_Service();

            if (tmrHours.Enabled)
            {
                btnStart.Text = "Stop";
            }
            else
            {
                btnStart.Text = "Start";
            }
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("yyyy-MM-dd HH:mm") == dtpDateTime.Value.ToString("yyyy-MM-dd HH:mm"))
            {
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    Switch_Service(checkedListBox1.CheckedItems[i].ToString(), false);
                }

                for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
                {
                    Switch_Service(checkedListBox2.CheckedItems[i].ToString(), true);
                }

                Load_Service();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                Switch_Service(checkedListBox1.CheckedItems[i].ToString(), false);
            }

            for (int i = 0; i < checkedListBox2.CheckedItems.Count; i++)
            {
                Switch_Service(checkedListBox2.CheckedItems[i].ToString(), true);
            }

            Load_Service();
        }
    }
}
