   M S B A M L   `   `   `  ����E  ABiblioteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Biblioteka
Biblioteka  5   	   #    Biblioteka.IzmenaKnjigeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Biblioteka     5   	     � Title$  Izmena knjige u listi��5   	   $	��450��6'   $	��800��64   .��5	      � $��Center=�6   $��Center=�6(    � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6;   .+�5      �� $��Sifra knjige:��6   $��Center=�6,   �� 5      -   5         ��Name$ sifraTextBox��5      $��-3 5 5 5q�6-   $��213.5��6?   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��0��6;   .+�5      �� $��Naslov knjige:��6   $��Center=�6-   �� 5      -   5        $ naslovKnjigeTextBox��5      $��-3 5 5 5q�63   $	��201��6E   5       �� 5"   
   $ 
Horizontal=�6   $��2��6.   $��0��6;   .+�5#      �� $��Autor knjige:��6   $��Center=�6,   �� 5$      -   5        $ autorTextBox��5$      $��-3 5 5 5q�6,   $	��207��6>   5%      �� 5'   
   $ 
Horizontal=�6   $��3��6.   $��0��6;   .+�5(      �� $��Zanr knjige:��6   $��Center=�6+   �� 5)      -   5        $ zanrTextBox��5)      $��-3 5 5 5q�6+   $	��212��6=   5*      �� 5,   
   $ 
Horizontal=�6   $��4��6.   $��0��6;   .+�5-      �� $��Dostupnost knjige:��6   $��Center=�61   �� 5.      -   5         ��Name$ dostupnostCB��5.      $��
-3 10 10 8q�6-   {�.  6A   5/      �� 51   
   $ 
Horizontal=�6   $��5��6.   $��0��6;   .+�52      �� -   5        $��Odaberite ikonicu��52      $	��100��61   $��5q�6=   6H   �� 53      -   5        $ IkonicaTextBox��53      $	��200��6.   $��5q�6:   {�.  6E   54      �� 56   
   $ 
Horizontal=�6   $��6��6.   $��0��6;   .+�57      �� -   5        $��Sacuvaj izmene��57      $��5q�6.   69   58      59      5:      