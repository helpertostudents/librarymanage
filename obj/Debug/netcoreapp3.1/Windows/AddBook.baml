   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   '    !Library_Managment.Windows.AddBook   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStartupLocation$  CenterScreen=�5	   	   $��Segoe UI Emoji)�5
   
    � 
ResizeMode$ NoResize=�5   	    � Title$ AddBook��5   	   $	��700��6   $
��1057��6'   .��5      � .+�5   
   � $��10,10,835,-112q�6   .+�5      �� $	��Top=�6   $��15q�61   .+�5      �� -   5         ��Name$ TxtBookName��5      $
��0,10q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$	 Adi��6=    %  !MaterialDesignFloatingHintTextBox#��[  6b   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 	TxtAuthor��5      $
��0,10q�6-   $ Yazici��6;   #��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 
TxtEdition��5      $
��0,10q�6.   $ Buraxilis Ili��6<   #��[  6k   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ TxtPrice��5      $
��0,10q�6,   $ Qiymeti��6:   #��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ TxtShelf��5      $
��0,10q�6,   $	 Ref��6:   #��[  6_   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5        $ 
TxtBarcode��5      $
��0,10q�6.   $ Barkod��6<   #��[  6d   $��Champagne & Limousines)�6�   $��18(�6�   �� 5      -   5         ��Name$ cmbCategory��5      $	��200��60   $��40��6<   $ 
Kateqoriya��6H    " MaterialDesignDataGridComboBox#��[ 6t   $��Champagne & Limousines)�6�   $��18(�6�    �� DisplayMemberPath$
 Name��5       �� SelectedValuePath$ Id��5      ��5   �   �� *
Category+ �� SelectedValue 5      �� *
Category+5      �� 5      -   5        	 ��Name$	 addBook��5      $��TESDIQLE��6&   $��40,356,67,104q�69   6P   �� 5      -	   5        $	 bookEdit��5      $��DEYIS��6'   $��40,393,67,70q�67   $y�Hidden=�6d   �� 5       -
   5        $	 
bookDelete��5       $	��SIL��6)   $��40,430,67,30q�67   $y�Hidden=�6f   5!      &   System.Windows.Controls.DataGrid  5"   
   -   5        
  Name$
 grdBooks��5"      $��347,0,10,114q�6&      AutoGenerateColumns$ False��6<      CanUserAddRows$ False��6X      
IsReadOnly$
 True��6p      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ ID��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5%      $ 0.15* 6%   $ Barkod��63    6C   �� *	Barcode+  5&      $ 0.20* 6%   $ Ad��63    6?   �� *
BookName+  5'      $ 0.20* 6%   $ Yazici��63    6C   �� *Author+  5(      $ 0.20* 6%   $ Qiymet��63    6C   �� *Price+  5)      $ 0.10* 6%   $
 Rəf��63    6@   �� *	Bookshelf+  5*      $ 0.15* 6%   $ Il��63    6?   �� *	Edition+  5,      $ 0.20* 6%   $ 
Kateqoriya��63    6G   �� *Category.Name+5  /MaterialDesignThemes.Wpf.DataGridComboBoxColumn  5-      5/      �� 50   
   -   5        $ txtSearchBook��50      $ Kitabi adina gore axtar��6*   #��[  6c   $��Champagne & Limousines)�6�   $��18(�6�   $��Center=�6  $��	0,598,0,0q�63   �� TextWrapping$
 Wrap=�6G  $	��Top=�6[  $	��222��6s  ��6�   ��  �� ElementName$ grdBooks�� �� Path$ SelectedItem.BookName�6  �� 51   
   -   5        $	 cancelBookEdit��51      $��cancel��6)   $
��Left=�6:   $��227,615,0,0q�6U   $	��Top=�6l   $	��125��6�   6�   �� 52   
   -   5        $ txtSearchBarcode��52      $ Barcodu daxil edin��6-   #��[  6a   $��Champagne & Limousines)�6�   $��18(�6�   $
��Left=�6  $��775,598,0,0q�6/  $
 Wrap=�6E  $	��Top=�6Y  $	��222��6q  ��6�   �� $ grdBooks��$ SelectedItem.BookName�6}  59      5;      