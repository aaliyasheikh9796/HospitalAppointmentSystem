   M S B A M L   `   `   `  ����T  PHospitalAppointmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:HospitalAppointmentSystemHospitalAppointmentSystem  5   	   (    "HospitalAppointmentSystem.HomePage   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:HospitalAppointmentSystem     5   	     � Title$  HomePage��5   	   $	��450��6   $	��800��6'   .��5
      � ���#D4F1F4 � RowDefinitions 5   
   �� 5      $��50 �6   5      �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $��* �6   .+�5   
   �� $��50��6   ���#189AB4$��2��61   ��5      �� 5       �� Color$ #189AB4��6"   5      �� 5   
   -   5        $��HospitalAppointment��5      $
��Left=�6.   $��45,0,0,0q�6I   $��Center=�6[   $��Bahnschrift Light)�6v   $��18(�6�   
�������$��2��6�   6�   �� 5   
   -   5         ��Name$ Image��5      $
��Left=�6   $��45��6:   $��8,0,0,0q�6F   $	��Top=�6W   $��57��6o   $3��-C:\Users\Vivek Sharma\Downloads\plusImage.png��6z   $��0��6�   �� 5   
   -   5         ��Name$ 	FilterBox��5       �� CornerRadius$ 10��6$   
������ $��	173,0,0,0q�6O   $	��200��6b   $��25��6n   $��Center=�6z   
�������$��1q�6�   $��2��6�   ._�5       �� -   5         ��Name$ 	searchbar��5        �� TextWrapping$
 Wrap=�6*   $��3q�6>   $��Bahnschrift Light)�6J   $��15(�6i   4  .System.Windows.Automation.AutomationProperties	   Name$	 	SearchBar��6w   
   HelpText$
 search��6�   
������ 
������ $��0q�6�   $��2��61  5!      �� 5"   
   $ 5��6   $��20��6#   $��60��6/   
����������	#FFFDFDFD$��1q�6e   $��2��6y   $��1��6�   $��50,0,0,0q�6�   ._�5#      �� -   5         ��Name$ search��5#      $��Search��6%   
�������
������ $��Bahnschrift Light)�6d   $��2��6�   5$      �� 5'   
   -   5         ��Name$ uname��5'      
�������$��16(�6O    J� RenderTransformOrigin$ -0.073,0.772&�6]   $��Bahnschrift Light)�6�   $��2��6�   $��Right=�6�   $��Center=�6�   ��6   �� *
username+6�   �� 5(   
   -   5        $��hi��5(      $
��Hii ��6   $��1��6)   $��15(�66   �� 5I   
   -   5         ��Name$ MyList��5I      $��1��6I   $��1��6Y   
������ $��Bahnschrift Light)�6�   ���	#FF05445E$��18(�6�   $	��Top=�6�   
���������6$   �� *doctorDetail+��5J      �� 5K      .R�5L      �  5M      �� 5N      $��50 �6/   �� 5O      $	��150 �6/   �� 5P      $	��150 �6/   �� 5Q      $	��150 �6/   �� 5R      $	��100 �6/   �� 5S      .+�5V      �� $ docId��6    $��0��6/   ��6@   �� *
DoctorId+�� 5X       ��Name$ DocName��6$   $��1��66   ��6F   �� *
DoctorName+�� 5Y      $��2��6$   ��64   �� *Degree+�� 5Z      $��3��6$   ��64   �� *Specilization+�� 5[      $��4��6!   $ 5��62   $��20��6C   $��60��6O   
���   �
������ $��1q�6�   ._�5\      �� $
 book��6%   -	   5        $
��Book��5\   3   $��8,0,8,0q�6B   
������ 
������ $��Center=�6�   $��Bahnschrift Light)�6�   $��12(�6�   ���	#FF05445E��6�   �� 5]      5^      5_      5a      �� 5b   
   -
   5         ��Name$ Speciallist��5b      $��1��6N   $��0��6[   
������ ���	#FF05445E��6'   �� *homePageDetail+��5c      �� 5d      .R�5e      � .+�5f      �� $��Bahnschrift Light)�6A   $��18(�6`    d� 	IsChecked$ FalseY�6n    d� IsThreeState$ False��6�   ���	#FF05445E$��30��6�   ��6$   �� *
Availble+6�   5g      5h      5k      5p      5r      