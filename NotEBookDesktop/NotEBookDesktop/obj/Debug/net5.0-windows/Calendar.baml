   M S B A M L   `   `   `  ����J  FNotEBookDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:NotEBookDesktopNotEBookDesktop  5          NotEBookDesktop.Calendar   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:NotEBookDesktop     5        � Title$  Calendar��5       � 
ResizeMode$ NoResize=�6   $	��228��6.   $	��648��6;   .��5
      � 
�������.+�5   
   &   System.Windows.Controls.Calendar  -   5          Name$ LeftCalendar��5      $
��Left=�6)   $��	26,19,0,0q�6D   $	��Top=�6W   $	��161��6o   $	��183��6|   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 	EventDate��5      $
��Left=�6(   $��
234,19,0,0q�6C   $	��Top=�6W   $��29��6o   �� 5   
   -   5         ��Name$ 	EventList��5      $��234,53,17,32q�6&    �� View 5      �� 5      .P�5      ��  �� Width$ 60��6%   $
��Date��60    �� DisplayMemberBinding 6>   �� *Date+�� 5      $	 240��6%   $��Event��61    6@   �� *Event+5      5      �� 5   
   -   5         ��Name$ EventTextBox��5      $
��Left=�6(   $��
377,19,0,0q�6C   $��Enter an Event��6W   	 �� TextWrapping$
	 Wrap=�6m   $	��Top=�6�   $	��172��6�   $��29��6�   $��14(�6�   �� 5   
   -   5        
 ��Name$
 EnterEventButton��5      $	��Add��6+   $
��Left=�69   $��
554,24,0,0q�6T   $	��Top=�6h   6�   �� 5   
   -   5        $
 RemoveEventButton��5      $��Remove��6,   $
��Left=�6=   $��
585,24,0,0q�6X   $	��Top=�6l    J� RenderTransformOrigin$ 0.643,-0.167&�6�   5      5      