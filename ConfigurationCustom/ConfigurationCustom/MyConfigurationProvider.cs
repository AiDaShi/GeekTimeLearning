using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace ConfigurationCustom
{
    class MyConfigurationProvider:ConfigurationProvider
    {

        Timer timer;

        public MyConfigurationProvider() : base()
        {
            timer = new Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 3000;
            timer.Start();
        }
        public override void Load()
        {
            //加载数据
            Load(false);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Load(true);
        }

        private void Load(bool v)
        {
            this.Data["lastTime"] = DateTime.Now.ToString();
            if (v)
            {
                base.OnReload();
            }
        }

    }
}
