   M S B A M L   `   `   `  ����D  @CRC_GAWEK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:CRC_GAWEK	CRC_GAWEK  5   	       CRC_GAWEK.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:CRC_GAWEK     5   	     � Title$  
MainWindow��5   	   $	��383��6   $	��800��6)   $	��800��65   $	��446��6D   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ bytes��5      $��89��6!   $��
28,53,32,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6U   6m   �� 5   
   -   5         ��Name$ start_button��5      $��Start��6'   $��
0,295,32,0q�67   $	��Top=�6K   $��Right=�6c   $��74��6   6�   �� 5   
   -   5        $ repeat_count��5      $
��Left=�6(   $��22��6C   $��
28,178,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��160��6�   $��1��6�   �� 5   
   $��Ilość powtórzeń:��6   $
��Left=�6+   $��
28,147,0,0q�6F   $	��Top=�6Z   �� 5   
   $��Wartość CRC��6   $
��Left=�6&   $��
28,236,0,0q�6A   $	��Top=�6U   �� 5   
   $)��#Łączny czas powtórzen algorytmu:��6   $
��Left=�6;   $��
28,205,0,0q�6V   $	��Top=�6j   �� 5   
   -   5        $ 	crc_value��5      $��23��6%   $��28,267,32,0q�61   $
 Wrap=�6F   $	��Top=�6Z   {�.  6r   �� 5   
   -   5         ��Name$
 time��5      $��0��6   $
��Left=�6*   $��224,205,0,0q�6E   $	��Top=�6Z   $	��114��6r   �� 5   
   $��
Sekwencja:��6   $
��Left=�6%   $��	28,22,0,0q�6@   $	��Top=�6S   5      5      