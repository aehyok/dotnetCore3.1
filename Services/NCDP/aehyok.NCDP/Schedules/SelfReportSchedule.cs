﻿using aehyok.Core.Schedule;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aehyok.NCDP.Schedules
{
    /// <summary>
    /// 测试自主填报的功能
    /// </summary>
    public class SelfReportSchedule(IServiceScopeFactory serviceFactory) : CronScheduleService(serviceFactory)
    {
        protected override string Expression { get; set; } = "0/1 * * * * ?";

        protected override bool Singleton => true;

        protected override Task ProcessAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(this.Expression, "表达式");
            Console.WriteLine("实现自主填报的功能");
            return Task.CompletedTask;
        }
    }
}
