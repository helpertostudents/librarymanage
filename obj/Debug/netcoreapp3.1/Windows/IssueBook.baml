   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   )    #Library_Managment.Windows.IssueBook   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � WindowStartupLocation$  CenterScreen=�5	   	   $��Segoe UI Emoji)�5
   
    � 
ResizeMode$ NoResize=�5   	    � Title$ 	IssueBook��5   	   $	��700��6   $
��1024��6(   .��5      � .+�5   
   � $��10,10,773,322q�6   .+�5      �� -   5         ��Name$ txtIssueCustomerName��5      $��40,102,41,0q�65    �� TextWrapping$
 Wrap=�6J   $	��Top=�6^   $	��160��6v   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Adi��6�    %  !MaterialDesignFloatingHintTextBox#��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerCode��5      $��
40,53,41,0q�64   $
 Wrap=�6H   $	��Top=�6\   $	��160��6t   $ Musteri Kodu��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6   �� 5      -   5        $ txtIssueCustomerSurname��5      $��40,151,41,0q�67   $
 Wrap=�6L   $	��Top=�6`   $	��160��6x   $ Soy Adi��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerTel��5      $��40,199,41,0q�63   $
 Wrap=�6H   $	��Top=�6\   $	��160��6t   $ Tel-No��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerEmail��5      $��40,248,41,0q�65   $
 Wrap=�6J   $	��Top=�6^   $	��160��6v   $ E-poct��6�   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtIssueCustomerId��5      $��
40,10,41,0q�62   $
 Wrap=�6F   $	��Top=�6Z   $	��160��6r   $ Musteri Id-si��6   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  6+  5      � 5   
   $��388,10,388,322q�6   .+�5      �� -   5        $ txtBookPrice��5      $��44,199,44,0q�6,   $
 Wrap=�6A   $	��Top=�6U   $	��160��6m   $ Qiymeti��6z   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -   5        $ txtBookName��5      $��44,150,44,0q�6+   $
 Wrap=�6@   $	��Top=�6T   $	��160��6l   $ 	Kitab Adi��6y   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -	   5        $ txtBookBarcode��5      $��
44,52,44,0q�6.   $
 Wrap=�6B   $	��Top=�6V   $	��160��6n   $ Kitab Barkod��6{   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  �� 5      -
   5        $ txtBookAuthor��5      $��44,101,44,0q�6-   $
 Wrap=�6B   $	��Top=�6V   $	��160��6n   $ Yazici��6{   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  (  "System.Windows.Controls.DatePicker  5      -   5          Name$ txtReturnDate��5      $��	0,248,0,0q�60   $	��Top=�6C   $	��150��6[   $��44��6g   $ Qaytarma Vaxti��6s     MaterialDesignDatePicker#��[ 6�   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 	txtBookId��5      $��
44,10,44,0q�6)   $
 Wrap=�6=   $	��Top=�6Q   $	��160��6i   $ Kitab Id-si��6v   #��[  6�   $��Champagne & Limousines)�6�   $��18(�6  $��44��6  6   5      &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ 	grdBasket��5       $��	0,362,0,0q�6&      AutoGenerateColumns$ False��69   	   CanUserAddRows$	 False��6U   
   
IsReadOnly$

 True��6m      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ ID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5#      $ 0.20* 6%   $ Kitab Id-si��63    6H   �� *	BooksId+  5$      $ 0.20* 6%   $ Goturme Tarixi��63    6K   �� *	IssueDate+  5%      $ 0.20* 6%   $ Qaytarma Tarixi��63    6L   �� *
ReturnDate+5'      �� 5(   
   -   5         ��Name$ btnIssueAddBook��5(      $��	Sebete At��6*   $
��Left=�6>   $��
722,99,0,0q�6Y   $	��Top=�6m   $��32��6�   $	��134��6�   6�   �� 5)   
   -   5        $ btnIssueDelete��5)      $��Sebetden Sil��6)   $
��Left=�6@   $��722,151,0,0q�6[   $	��Top=�6p   $��32��6�   $	��134��6�   6�   �� 5*   
   -   5        $ btnIssueCancel��5*      $��Sifarisi Legv Et��6)   $
��Left=�6D   $��722,202,0,0q�6_   $	��Top=�6t   $��32��6�   $	��134��6�   6�   �� 5+   
   -   5        $ btnIssueAccept��5+      $��Sifarisi Tesdiqle��6)   $
��Left=�6E   $��722,258,0,0q�6`   $	��Top=�6u   $��32��6�   $	��134��6�   6�   5-      5.      