   M S B A M L   `   `   `  ����@  <tegla, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:teglategla  5   	   1clr-namespace:tegla.ViewModeltegla.ViewModel  5   	       tegla.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:tegla     5   	   3	viewmodelclr-namespace:tegla.ViewModel     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��450��6)    � DataContext 5
      '   !tegla.ViewModel.TeglalapViewModel  5   
   .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��2��6   $��20(�61   $
��Bold"�6?   $��Center=�6Q   $��Center=�6l   .��6�   Téglalap kalkulátor6�   �� 5   
   $��1��6   $��0��6   $
��Left=�6-   $��Center=�6H   $��15(�6c   .��6q   Egyik oldalhossz:6�   �� 5    
   $��2��6   $��0��6   $
��Left=�6-   $��Center=�6H   $��15(�6c   .��6q   Másik oldalhossz:6�   �� 5!   
   $��3��6   $��0��6   $
��Left=�6-   $��Center=�6H   $��15(�6c   .��6q   	Terület:6{   �� 5"   
   $��4��6   $��0��6   $
��Left=�6-   $��Center=�6H   $��15(�6c   .��6q   	Kerület:6{   �� 5#   
   $��5��6   $��0��6   $
��Left=�6-   $��Center=�6H   $��15(�6c   .��6q   Átló hossza:6   �� 5%   
   $��1��6   $��1��6   $	��150��6/   $��30��6;   ��6G   �� *	Oldal_1+ �� Mode$ TwoWay=�6o   �� 5&   
   $��2��6   $��1��6   $	��150��6/   $��30��6;   ��6G   �� *	Oldal_2+$ TwoWay=�6o   �� 5'   
   $��3��6   $��1��6   $	��150��6/   $��30��6;    �� 
IsReadOnly$
 True��6m   ��6G   �� *	Terulet+$ OneWay=�6�   �� 5(   
   $��4��6   $��1��6   $	��150��6/   $��30��6;   $
 True��6m   ��6G   �� *	Kerulet+$ OneWay=�6�   �� 5)   
   $��5��6   $��1��6   $	��150��6/   $��30��6;   $
 True��6j   ��6G   �� *Atlo+$ OneWay=�6~   �� 5+   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Center=�6O   .+�5,      �� $	��150��6   $��30��6!   $��Számol��6-   $��10q�6c   ��6>   �� *CalculateCommand+6q   �� 5-      $	��150��6   $��30��6!   $��Kilép��6-   ��6=   �� *CloseCommand+6`   5.      50      51      