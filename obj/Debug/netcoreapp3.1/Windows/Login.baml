   M S B A M L   `   `   `  ����L  HLibrary Managment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Library_Managment.WindowsLibrary_Managment.Windows  5   	   %    Library_Managment.Windows.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Library_Managment.Windows     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStartupLocation$  CenterScreen=�5	   	   $��Segoe UI Emoji)�5
   
    � Title$ Login��5   	   $	��500��6   $	��320��6$    � 
ResizeMode$ NoResize=�5   
   .��5      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H    �� RadiusY$ 10��6V    �� RadiusX$ 10��6c   
�������	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5      � 5   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5      �� $��LOGIN��6   $��Center=�6$   $	��Top=�6A   $��5q�6Y   
�������$��18(�6v   �� 5       $��Center=�6   $��15q�64   .+�5!      �� -   5         ��Name$ TxtUsername��5!      $
��0,10q�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ istifadəçi adı��6=    %  !MaterialDesignFloatingHintTextBox#��[  6m   $��Champagne & Limousines)�6�   $��18(�6�   G� 5"      -   5         G�Name$ TxtPassword��5"      $
��0,10q�63   $ şifrə��6A    ) %MaterialDesignFloatingHintPasswordBox#��[ 6h   $��Champagne & Limousines)�6�   $��18(�6�   5#      5$      �� 5%   
   -   5         ��Name$ BtnLogin��5%      $	��150��6#   $��Center=�6/   $��Bottom=�6L   $
��0,65q�6g   $��	DAXİL OL��6u   6�   �� 5&   
   $��Şifrəni unutmusunuz?��6   $��Center=�60   $��Bottom=�6M   $��30q�6h   
������� � Cursor$
 Hand��6�   �� 5'   
   $��/Assets/home.png��6   $	��100��6*   $��110,30,110,354q�66   5(      5)      