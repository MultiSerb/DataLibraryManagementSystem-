   M S B A M L   `   `   `  ����E  ABiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Biblioteka
Biblioteka  5   	   "    Biblioteka.DodajKnjiguWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Biblioteka     5   	     � Title$*  $Dodavanje nove knjige u listu knjiga��5   	   $	��300��66   $	��650��6C    � WindowStartupLocation$ CenterScreen=�6O   .��5	      � $��Center=�6   $��Center=�6(    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6;   .+�5      �� $��Sifra nove knjige:��6   $��Center=�61   �� 5      -   5         ��Name$ sifraTextBox��5      $��3q�6-   $	��213��68   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��0��6;   .+�5      �� $��Naslov nove knjige:��6   $��Center=�62   �� 5      -   5        $ naslovKnjigeTextBox��5      $��3q�63   $	��202��6>   5       �� 5"   
   $ 
Horizontal=�6   $��2��6.   $��0��6;   .+�5#      �� $��Autor nove knjige:��6   $��Center=�61   �� 5$      -   5        $ autorTextBox��5$      $��3q�6,   $	��206��67   5%      �� 5'   
   $ 
Horizontal=�6   $��3��6.   $��0��6;   .+�5(      �� $��Zanr nove knjige:��6   $��Center=�60   �� 5)      -   5        $ zanrTextBox��5)      $��3q�6+   $	��213��66   5*      �� 5,   
   $ 
Horizontal=�6   $��4��6.   $��0��6;   .+�5-      �� $��Dostupnost nove knjige:��6   $��Center=�66   �� 5.      -   5         ��Name$ dostupnostCheckBox��5.       d� 	IsChecked$
 TrueY�63   {�.  $��
-3 10 10 8q�6V   5/      �� 50   
   $��5��6   $��0��6"   $ 
Horizontal=�62   .+�51      �� -   5        $��Odaberite ikonicu��51      $	��100��61   $��5q�6=   6H   �� 52      -   5        $ IkonicaTextBox��52      $	��200��6.   $��5q�6:   {�.  6E   53      �� 54   
   $ 
Horizontal=�6   $��6��6.   $��0��6;   .+�55   
   �� -   5        $&�� Dodaj novu knjigu u listu knjiga��55      $��5q�6<   6G   56      57      58      