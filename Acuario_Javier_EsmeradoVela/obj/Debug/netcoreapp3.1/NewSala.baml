   M S B A M L   `   `   `  ����V  RAcuario_Javier_EsmeradoVela, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Acuario_Javier_EsmeradoVelaAcuario_Javier_EsmeradoVela  5   	   )    #Acuario_Javier_EsmeradoVela.NewSala   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Acuario_Javier_EsmeradoVela     5   	     � Title$  NewSala��5   	   $	��400��6   $	��350��6&   $��Normal$�62    � WindowStyle$
 None=�6E   ��5	      
� 5
   
   .��5      �  � Color$ 	#FFA3F1F1��6    � Offset$ 1Q�6-   � 5      $ 	#FF008585��6   5      .��5      � ���	#FF488286 � RowDefinitions 5   
   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6   �� 5      $��25 �6    � ColumnDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��60 �6   .+�5   
   �� $��Nombre de Sala: ��6   $��0��6+   $��0��68   $��10,0,0,0q�6H   �� 5   
   $��Temperatura: ��6   $��1��6(   $��0��65   $��5,23,5,1q�6E   $��2��6W   �� 5   
   $��	Especie: ��6   $��3��6$   $��Center=�61   $	��115��6N   $��0,23,0,3q�6Z   $��2��6l   �� 5   
   $��Fecha Revision: ��6   $��4��6+   $��0��68   $��
5,46,5,-47q�6H   �� 5   
   $��Tratamiento: ��6   $��4��6(   $��0��65   $��10,103,0,-103q�6E   �� 5    
   -   5         ��Name$ 
input_name��5       $��1��6&   $��2��63   $��	10,0,30,1q�6G   �� 5!   
   -   5        $ input_temperatura��5!      $��2��6-   $��2��6:   $��
10,24,30,2q�6N   $��2��6b   �� 5"   
   -   5        $ input_especie��5"      $��4��6)   $��2��66   $��10,22,30,-21q�6J   (  "System.Windows.Controls.DatePicker  5#   
   -   5          Name$ input_fecharevision��5#      $��4��62   $��2��6?   $��10,72,30,-71q�6S   �� 5$   
   -   5        $ input_tratamiento��5$      $��4��6-   $��10,128,30,-128q�6:   $��2��6R   � 5%   
   $��0,146,-85,-166q�6   $��4��6'   $��2��64   .+�5&      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   $	��260��6O   $��
0,22,0,-23q�6[   .+�5'      �� -   5        $��Añadir��5'      $	��100��6*   $��30��66   ��5(      �� 5)      	 �� EndPoint$	 0.5,1&�6.   
 �� 
StartPoint$
 0.5,0&�6?   .��5*      � $ 	#FF6BAFB4��6+   $ 0.234Q�6=   � 5+      $ 	#FF8BD4F7��6+   $ 1Q�6=   5,      5.      �� 5/      -   5        $��Volver��5/      $	��100��6*   $��30��66   ��50      �� 51      $	 0.5,1&�6.   $
 0.5,0&�6?   .��52      � $	 Red��6+   $ 0.221Q�67   � 53      $ 	#FFB83838��6+   $ 1Q�6=   54      56      57      59      5:      5;      