#pragma checksum "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e0a1fed42070bbce49cafdb1d66f51072ec2c7c"
// <auto-generated/>
#pragma warning disable 1591
namespace NotEBookWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using NotEBookWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazor.Extensions.Canvas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/calculator")]
    public partial class Calculator : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Calculator</h1>\r\n\r\n");
            __builder.OpenElement(1, "label");
            __builder.AddAttribute(2, "class", "ans-display");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                            answer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "calculator");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "buttons");
            __builder.OpenElement(9, "span");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn7)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(12, (__value) => {
#nullable restore
#line 12 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn7 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(13, "7");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn8)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(17, (__value) => {
#nullable restore
#line 13 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn8 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(18, "8");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn9)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(22, (__value) => {
#nullable restore
#line 14 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn9 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(23, "9");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                           () => inputOperation(@add)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(27, (__value) => {
#nullable restore
#line 15 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          add = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(28, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        <br>\r\n        ");
            __builder.OpenElement(30, "span");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn4)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(33, (__value) => {
#nullable restore
#line 19 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn4 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(34, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn5)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(38, (__value) => {
#nullable restore
#line 20 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn5 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(39, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn6)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(43, (__value) => {
#nullable restore
#line 21 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn6 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(44, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                                () => inputOperation(subtract)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(48, (__value) => {
#nullable restore
#line 22 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          subtract = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(49, "-");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        <br>\r\n        ");
            __builder.OpenElement(51, "span");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(54, (__value) => {
#nullable restore
#line 26 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn1 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(55, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(59, (__value) => {
#nullable restore
#line 27 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn2 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(60, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn3)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(64, (__value) => {
#nullable restore
#line 28 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn3 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(65, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                                () => inputOperation(multiply)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(69, (__value) => {
#nullable restore
#line 29 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          multiply = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(70, "*");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        <br>\r\n        ");
            __builder.OpenElement(72, "span");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                          () => inputNum(@btn0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(75, (__value) => {
#nullable restore
#line 33 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         btn0 = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(76, "0");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                         () => inputNum(@dec)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(80, (__value) => {
#nullable restore
#line 34 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                         dec = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(81, ".");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                                () => inputOperation(exponent)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(85, (__value) => {
#nullable restore
#line 35 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          exponent = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(86, "x");
            __builder.AddMarkupContent(87, "<sup>y</sup>");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                              () => inputOperation(divide)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddElementReferenceCapture(91, (__value) => {
#nullable restore
#line 36 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          divide = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(92, "/");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n        <br>\r\n        ");
            __builder.OpenElement(94, "span");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                () => clearCalculator()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "class", "btn btn-outline-primary");
            __builder.AddContent(98, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n            ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                                             () => inputOperation(enter)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "class", "btn btn-primary");
            __builder.AddElementReferenceCapture(103, (__value) => {
#nullable restore
#line 41 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
                          enter = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddContent(104, "Enter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\.NET_Projects\490-NotEBook\NotEBookWeb\NotEBookWeb\Pages\Calculator.razor"
       
    private string answer, op;
    private int State;
    private float num1, num2;
    private ElementReference btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0, dec;
    private ElementReference add, subtract, multiply, divide, exponent, clear, enter;
    private BindElementAttribute d;

    private Dictionary<ElementReference, string> numberButtons;
    private Dictionary<ElementReference, string> operationButtons;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        answer = "0";
        State = 0;

    }

    /*Initialize dictionaries for numbers and operations*/
    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);


        numberButtons = new Dictionary<ElementReference, string>() {

            { btn1, "1" },
            { btn2, "2" },
            { btn3, "3" },
            { btn4, "4" },
            { btn5, "5" },
            { btn6, "6" },
            { btn7, "7" },
            { btn8, "8" },
            { btn9, "9" },
            { btn0, "0" },
            { dec, "." }
        };

        operationButtons = new Dictionary<ElementReference, string>() {

                { add, "+"},
                { subtract, "-"},
                { multiply, "*"},
                { divide, "/"},
                {exponent, "^" },
                {enter, "e" }
        };

    }

    /*State manager for number inputs*/
    private async void inputNum(ElementReference element)
    {
        //first input
        if (State == 0)
        {
            answer = numberButtons[element];
            State = 1;
        }

        //add to first input
        else if (State == 1)
        {
            answer += numberButtons[element];
            State = 1;
        }

        //all input strings following first input
        else if (State == 2)
        {
            answer = numberButtons[element];
            State = 3;
        }

        //add to all input strings following first input
        else if (State == 3)
        {
            answer += numberButtons[element];
            State = 3;
        }


        //await JSRuntime.InvokeVoidAsync("setElementText", element);

    }

    /*State manager for operation inputs*/
    private async void inputOperation(ElementReference element)
    {
        //store operand and save current input in num1
        if (State == 1 || op == "e")
        {
            num1 = float.Parse(answer);
            op = operationButtons[element];
            State = 2;
        }

        //perform operations
        if (State == 3)
        {

            num2 = float.Parse(answer);

            if (op == "+")
                answer = Convert.ToString(num1 + num2);

            else if (op == "-")
                answer = Convert.ToString(num1 - num2);

            else if (op == "*")
                answer = Convert.ToString(num1 * num2);

            else if (op == "/")
                answer = Convert.ToString(num1 / num2);

            else if (op == "^")
                answer = Convert.ToString(Math.Pow(num1, num2));


            op = operationButtons[element];
            num1 = float.Parse(answer);
            State = 2;

        }


    }

    private void clearCalculator()
    {
        answer = "0";
        num1 = num2 = 0;
        op = "";
        State = 0;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
