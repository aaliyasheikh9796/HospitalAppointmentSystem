   M S B A M L   `   `   `  ����T  PHospitalAppointmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HospitalAppointmentSystemHospitalAppointmentSystem  5   	   +    %HospitalAppointmentSystem.Appointment   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:HospitalAppointmentSystem     5   	     � Title$  Appointment��5   	   $	��450��6   $	��800��6*   .��5	      � ���#D4F1F4 J� Opacity$	 0.7Q�6     � RowDefinitions 5
   
   �� 5      $��50 �6   5      �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��650 �6   .+�5   
   �� $
��Left=�6   $��50��6/   ���#189AB4$��Center=�6L   $	��800��6g   $��2��6s   ��5      �� 5       �� Color$ #189AB4��6"   5      �� 5   
   $��HospitalAppointment��6   $
��Left=�6/   $��45,0,0,0q�6J   $��Center=�6\   $��Bahnschrift Light)�6w   $��18(�6�   
�������$��2��6�   �� 5   
   -   5         ��Name$ Image��5      $
��Left=�6   $��45��6:   $��8,0,0,0q�6F   $	��Top=�6W   $��57��6o   $3��-C:\Users\Vivek Sharma\Downloads\plusImage.png��6z   $��0��6�   �� 5   
   -   5         ��Name$ 	FilterBox��5       �� CornerRadius$ 10��6$   
������ $��	173,0,0,0q�6O   $	��200��6b   $��25��6n   $��Center=�6z   $
��Left=�6�   
�������$��1q�6�   $��1��6�   ._�5      �� -   5         ��Name$ 	searchbar��5      	 �� TextWrapping$
	 Wrap=�6*   $��3q�6>   $��Bahnschrift Light)�6J   $��15(�6i   4  .System.Windows.Automation.AutomationProperties
   HelpText$
 search��6x   
������ 
������ $��0q�6�   5!      �� 5'   
   -   5         ��Name$
 name��5'      $��UserName��6   $
��Left=�61   $��
543,15,0,0q�6L   $	��Top=�6`   $��Right=�6x   $��Bottom=�6�   
�������$��16(�6�    J� RenderTransformOrigin$ -0.073,0.772&�6�   $��Bahnschrift Light)�6  $��0��6"  $��1��6/  �� 5(   
   $��1��6   $��1��6!   $	��200��6.   $ 15��6:   
������ $��1q�6f   $��23,92,427,217q�6z   ._�5*      �� $��Doctor Name��6   $
��Left=�6*   $��Center=�6E   $��20(�6`   $��Bahnschrift Light)�6n   5,      �� 5-   
   $��Label��6   �� 5.   
   -   5        $ 
doctorName��5.      $��1��6$   $
��Left=�6P   $��250,110,0,0q�6k   $��1��6�   $	��Top=�6�   $��25(�6�   $��Bahnschrift Light)�6�   ��64   �� *	docName+6�   50      51      