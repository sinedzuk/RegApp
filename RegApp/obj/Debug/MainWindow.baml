   M S B A M L   `   `   `  ����A  =RegApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:RegAppRegApp  5   	       RegApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:RegApp     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #ffa114��6'    � Offset$	 0.0Q�67   � 5      $ #fff154��6'   $ 1Q�67   5      5      �� 5      -   5        $��X��5      $��20��6!   $��22��6-   $��Right=�68   $	��Top=�6T   6l   �� 5       $��0��6   $��Center=�6&   .+�5!      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Movie=�6-   $	��100��5"   -   $��50��5#   -   $��Center=�5$   1   $��Center=�5%   1   
�������5&   1   �� 5(      $��0,10,0,0q�6   $��Cinema Project��5)      $��Light"�5*      $��	Helvetica)�5+      $��22(�5,      
�������$��Center=�5.      5/      �� 52      $��1��6   .+�53      �� 	 �� Orientation$	 
Horizontal=�6   .+�54      �� -   5        $��LoginBox��54      $��	Helvetica)�55      $��Light"�56      $��Username��57      $��20(�58      $��Center=�59      
�������
������ $��0q�5<      $	��235��5=      $
��Left=�5>      
 J� Opacity$	
 0.6Q�5?      $��25��5@      $��63,0,0,0q�5A        5B      $ Account=�61   $��Center=�5C   1   $��Center=�5D   1   
�������5E   1   5F      �� 5G      $	��250��6   $��2��5H      
�������$	
 0.6Q�5J      �� 5N      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5O      G� -   5        $��PassBox��5P      $��	Helvetica)�5Q      $��Light"�5R       G� Password$ Password��5S      $��20(�5T      $��Center=�5U      
�������
������ $��0q�5X      $	��235��5Y      $
��Left=�5Z      $	
 0.6Q�5[      $��25��5\      $��63,0,0,0q�5]        5^      $
 Lock=�61   $��Center=�5_   1   $��Center=�5`   1   
�������5a   1   5b      �� 5c      $	��250��6   $��2��5d      
�������$	
 0.6Q�5f      �� 5h      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�5i      �� -   5        $	��100��5i      $��40��6)   $��LOGIN��65   $��	60,0,60,0q�6E   6X   �� 5j      -   5        $	��100��5j      $��40��6)   $��REGISTER��65   6H   5k      5n      5u      5v      5w      