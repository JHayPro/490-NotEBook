// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NotEBookWeb.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
    public partial class Calander : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\Calander.razor"
       
    int currentYear = DateTime.Today.Year;
    int currentMonth = DateTime.Today.Month;
    List<List<CalanderDay>> days;
    int firstWeekDayNum;


    private List<TodoItem> todos = new List<TodoItem>();
    private string newTask;
    private DateTime newDate = DateTime.Today;
    private DateTime newTime = DateTime.Now;


    protected override void OnInitialized()
    {
        base.OnInitialized();

        days = new List<List<CalanderDay>>(new List<CalanderDay>[12]);

        for (int i = 0; i < 12; i++)
        {
            days[i] = new List<CalanderDay>();

            //days[currentMonth] = new List<CalanderDay>();

            var firstDayDate = new DateTime(currentYear, i + 1, 1);
            firstWeekDayNum = (int)firstDayDate.DayOfWeek;
            int numEmptyDays = 0;
            int numWeekRows = 0;
            int numDaysinMonth = 0;

            if (numEmptyDays == 7)
            {
                numEmptyDays = 0;
            }
            else
            {
                numEmptyDays = firstWeekDayNum;
            }

            for (int j = 0; j < numEmptyDays; j++)
            {
                days[i].Add(new CalanderDay
                {
                    DayNum = 0,
                    isEmpty = true
                });
            }

            numDaysinMonth = DateTime.DaysInMonth(currentYear, i + 1);

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\Calander.razor"
             for (int j = 1; j <= numDaysinMonth; j++)
            {
                days[i].Add(
                    new CalanderDay()
                    {
                        DayNum = j,
                        isEmpty = false,
                        Date = new DateTime(currentYear, i + 1, j),
                        Events = new List<TodoItem>()
                    });
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 171 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\Calander.razor"
             


            numWeekRows = (int)Math.Ceiling(DateTime.DaysInMonth(currentYear, currentMonth) / 7.0);
        }

        updateCalander();
    }

    void selectYear(ChangeEventArgs e)
    {
        currentYear = Convert.ToInt32(e.Value.ToString());

        updateCalander();
    }

    void selectMonth(ChangeEventArgs e)
    {

        currentMonth = Convert.ToInt32(e.Value.ToString());
        newDate = new DateTime(currentYear, currentMonth, 1);


        updateCalander();
    }

    public void updateCalander()
    {

        var firstDayDate = new DateTime(currentYear, currentMonth, 1);
        firstWeekDayNum = (int)firstDayDate.DayOfWeek;
        int numEmptyDays = 0;
        int numWeekRows = 0;
        int numDaysinMonth = 0;

        if (numEmptyDays == 7)
        {
            numEmptyDays = 0;
        }
        else
        {
            numEmptyDays = firstWeekDayNum;
        }


        numDaysinMonth = DateTime.DaysInMonth(currentYear, currentMonth);
        numWeekRows = (int)Math.Ceiling(DateTime.DaysInMonth(currentYear, currentMonth) / 7.0);

    }


    [Parameter]
    public RenderFragment<CalanderDay> DayTemplate { get; set; }


    public void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTask) /*&& newDate.Month == currentMonth*/)
        {
            int calanderEventDayIndex = (newDate.Day + firstWeekDayNum) - 1;
            todos.Add(new TodoItem { Title = newTask, Date = newDate, Time = newTime });
            days[newDate.Month - 1][calanderEventDayIndex].Events.Add(todos[todos.Count - 1]);
            newTask = string.Empty;
            newDate = DateTime.Today;
            newTime = DateTime.Now;

            //Add event to calander UI


        }
    }

    public void updateEvent()
    {
        //updateCalander();

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 247 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\Calander.razor"
         foreach (var todo in todos)
        {
            int currentIndex1 = (todo.Date.Day + firstWeekDayNum) - 1;
            int currentIndex2 = (todo.Time.Day + firstWeekDayNum) - 1;
            todo.Time = todo.Date;
            days[currentMonth - 1][currentIndex1].Events.Add(todo);
            days[currentMonth - 1][currentIndex2].Events.Clear();

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 255 "D:\.NET Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Controls\Calander.razor"
         
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
