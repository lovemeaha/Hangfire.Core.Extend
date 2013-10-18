﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\DequeuedJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\DequeuedJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\DequeuedJobsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\DequeuedJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class DequeuedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");







            
            #line 7 "..\..\Pages\DequeuedJobsPage.cshtml"
  
    Layout = new LayoutPage
        {
            Title = Queue.ToUpperInvariant(),
            Subtitle = "Dequeued jobs",
            Breadcrumbs = new Dictionary<string, string>
                {
                    { "Queues", Request.LinkTo("/queues") },
                    { Queue.ToUpperInvariant(), Request.LinkTo("/queues/" + Queue) }
                },
            BreadcrumbsTitle = "Dequeued jobs",    
        };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var pager = new Pager(from, perPage, JobStorage.DequeuedCount(Queue))
    {
        BasePageUrl = Request.LinkTo("/queues/dequeued/" + Queue)
    };

    var dequeuedJobs = JobStorage.DequeuedJobs(Queue, pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 33 "..\..\Pages\DequeuedJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        The queue is empty.\r\n    </div>\r\n");


            
            #line 38 "..\..\Pages\DequeuedJobsPage.cshtml"
}
else
{
    
            
            #line default
            #line hidden
            
            #line 41 "..\..\Pages\DequeuedJobsPage.cshtml"
Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
            
            #line 41 "..\..\Pages\DequeuedJobsPage.cshtml"
                                              
    

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Id</th>
                <th>State</th>
                <th>Job type</th>
                <th>Args</th>
                <th>Created</th>
                <th>Fetched</th>
                <th>Checked</th>
            </tr>
        </thead>
        <tbody>
");


            
            #line 56 "..\..\Pages\DequeuedJobsPage.cshtml"
             foreach (var job in dequeuedJobs)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <a href=\"" +
"");


            
            #line 60 "..\..\Pages\DequeuedJobsPage.cshtml"
                            Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 60 "..\..\Pages\DequeuedJobsPage.cshtml"
                                                                Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                    </td>\r\n                    <td>\r\n                      " +
"  <span class=\"label label-default\" style=\"");


            
            #line 63 "..\..\Pages\DequeuedJobsPage.cshtml"
                                                             Write(JobHistoryRenderer.ForegroundStateColors.ContainsKey(job.Value.State) ? String.Format("background-color: {0};", JobHistoryRenderer.ForegroundStateColors[job.Value.State]) : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 64 "..\..\Pages\DequeuedJobsPage.cshtml"
                       Write(job.Value.State);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    </td>\r\n                    <td>");


            
            #line 66 "..\..\Pages\DequeuedJobsPage.cshtml"
                   Write(HtmlHelper.JobType(job.Value.Type));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n                        <pre class=\"pre-args\">");


            
            #line 68 "..\..\Pages\DequeuedJobsPage.cshtml"
                                         Write(HtmlHelper.FormatProperties(job.Value.Args));

            
            #line default
            #line hidden
WriteLiteral("</pre>\r\n                    </td>\r\n                    <td>\r\n");


            
            #line 71 "..\..\Pages\DequeuedJobsPage.cshtml"
                         if (job.Value.CreatedAt.HasValue)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-moment=\"");


            
            #line 73 "..\..\Pages\DequeuedJobsPage.cshtml"
                                          Write(JobHelper.ToStringTimestamp(job.Value.CreatedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 74 "..\..\Pages\DequeuedJobsPage.cshtml"
                           Write(job.Value.CreatedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");


            
            #line 76 "..\..\Pages\DequeuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>\r\n");


            
            #line 79 "..\..\Pages\DequeuedJobsPage.cshtml"
                         if (job.Value.FetchedAt.HasValue)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-moment=\"");


            
            #line 81 "..\..\Pages\DequeuedJobsPage.cshtml"
                                          Write(JobHelper.ToStringTimestamp(job.Value.FetchedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 82 "..\..\Pages\DequeuedJobsPage.cshtml"
                           Write(job.Value.FetchedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");


            
            #line 84 "..\..\Pages\DequeuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                    <td>\r\n");


            
            #line 87 "..\..\Pages\DequeuedJobsPage.cshtml"
                         if (job.Value.CheckedAt.HasValue)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span data-moment=\"");


            
            #line 89 "..\..\Pages\DequeuedJobsPage.cshtml"
                                          Write(JobHelper.ToStringTimestamp(job.Value.CheckedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                ");


            
            #line 90 "..\..\Pages\DequeuedJobsPage.cshtml"
                           Write(job.Value.CheckedAt);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </span>\r\n");


            
            #line 92 "..\..\Pages\DequeuedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </td>\r\n                </tr>\r\n");


            
            #line 95 "..\..\Pages\DequeuedJobsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");


            
            #line 98 "..\..\Pages\DequeuedJobsPage.cshtml"
    
    
            
            #line default
            #line hidden
            
            #line 99 "..\..\Pages\DequeuedJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 99 "..\..\Pages\DequeuedJobsPage.cshtml"
                                        
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
