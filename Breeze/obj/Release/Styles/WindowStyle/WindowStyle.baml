   M S B A M L   `   `   `  ���� 
  Breeze    Breeze.Styles.WindowStyleR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TitleBarBackgroundBrush  �� Color  WindowBorderBrush  WindowBorderBrushMin  WindowBorderBrushMax  WindowBorderBrushClose  WindowBorderBrushInactive  WindowStatusForeground " WindowStatusForegroundInactive   WindowStyleTitleBarButtonMin �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName  	 WindowStyleTitleBarButtonMax "
 WindowStyleTitleBarButtonClose  WindowStyle&   System.Windows.Media.TextOptions
   TextRenderingMode   TextFormattingMode �� Padding J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   Color   Opacity   
BlurRadius   ShadowDepth   	Direction � ColumnDefinitions ��Name �� Path �� Mode �� RelativeSource ��Name J� Opacity ��Name �� Stretch �� EdgeMode �� AncestorType F�Name ��Name  � Cursor	! �� X1" � ActualWidth	# �� X2	$ �� Y1	% �� Y2& � ActualHeight' ��Name( �� 	Resources) �� Triggers* �� Binding+ �� Value   D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     %<  &	        &	      &	 &     &	 6     &	 I     &	 \     &	 o     &	 �     &	 �     7  &		     7  &	
 �    7  &	 �    7  7   7  7 	 7 
 7  7  7  7  7  �� $  #EFEFF2���� $  #007ACC���� $
  #FFF���� $  #007ACC���� $  #FF0000���� $  #999999���� $  #FFFFFF���� $  #FFFFFF���� " ��.���  � |� .  ��  � �� �� " ��.R�� .+��� $ PART_border��
������ ��  P�  �@J�IsMouseOver . . ��� $	 PART_border�� � �� �#FFF�� $	 PART_border�� �@J�Opacity$	 0.1Q�P�  � �� . . ��� $	 PART_border��8    � ���� $	 PART_border�� �@J�Opacity$	 0.4Q���  � �� �#FFF�� " ��.���  � |� .  ��  � �� �� " ��.R�� .+��� $ PART_border��
������ ��  P�  �@J�IsMouseOver . . ��� $	 PART_border�� � �� �#007ACC�� $	 PART_border�� �@J�Opacity$	 0.3Q�P�  � �� . . ��� $	 PART_border��8    � ���� $	 PART_border�� �@J�Opacity$	 0.9Q���  � �� �#FFF�� " ��.���  � |� .  ��  � �� �� " ��.R�� .+��� $ PART_border��
������ ��  P�  �@J�IsMouseOver . . ��� $	 PART_border�� � �� �#FF0000�� $	 PART_border�� �@J�Opacity$	 0.3Q�P�  � �� . . ��� $	 PART_border��8    � ���� $	 PART_border�� �@J�Opacity$	 0.8Q���  � �� �#FFF�� " �.���  �@�AllowsTransparency . ��  �@�WindowStyle$
 None=���  � ��
 ���� ��  �@�
ResizeMode$ CanResizeWithGrip=���  � �� �� " �.R�� $��7q�$
 	ClearType=�$ Display=�.+��� $ PART_Border��$
��Auto��$
��Auto�����#4343438��  $��1q�$ 0q�   $ black��$	 0.5Q�$ 7Q�$ 2Q�$	 315Q�._�]� $��Stretch=�
������ $��Stretch=�.+��� $ TitleBar��-   $	��Top=�8�� $��0q�._�� $��32�����#1E1E1E �� $��36 ��� �� $��34 ��� $��34 ��� $��46 �.+��� $
 Icon��$��0��$��-2,0,0,0q�$��34��$��36��$
��Fill=����� $
 Icon�$ OneWay=� �� *TemplatedParent+�� $ Caption��$��1��$
��Left=�$��Center=�$��4,0,0,0q�$��Segoe UI)�$��20(�$��Light"�$	 0.8Q�
����������� $ Title�$ OneWay=� �� *TemplatedParent+�� $ 	MinButton��-   $��2��$	��Top=�$��34��$��22��8�� 
�������.��� $��9��$��9��.+�F� $��1��$
 None=�$ Aliased=�=����     z � z  z �    ��j � z ��j �    ��[ � z ��[ 	����  �� $ ButtonL�$ 
Foreground��� $ 	MaxButton��-   $��3��$	��Top=�$��34��$��22��8�� 
�������.��� $��9��$��9��.+�F� $ PART_MaxButton_Path��$��1��$
 None=�$ Aliased=�X����        � z     � z  z �     z �        �    @B � z @B �    �� � z �� 	����  �� $ ButtonL�$ 
Foreground��� $ CloseButton��-   $��4��$	��Top=�$��46��$��22��8�� 
�������.��� $��9��$��9��.+�F� $	��1.5��$
 None=�+����        � z  z �     z � z     	����  �� $ ButtonL�$ 
Foreground��� �� $ lnSizeNorth��-   
������ $  SizeNS��$! 1��## z" $$ 1��$% 1��$��3���� $ lnSizeSouth��-   
������ $��Bottom=�$  SizeNS��$! 1��## z" #$ z& #% z& $��3���� $ 
lnSizeWest��-   
������ $  SizeWE��$! 1��$# 1��$$ 1��#% z& $��3���� $ 
lnSizeEast��-   
������ $��Right=�$  SizeWE��#! z" ## z" $$ 1��#% z& $��3���� $' rectSizeNorthWest��-	   $  SizeNWSE��
������ $��5��$��5��$	��Top=�$
��Left=��� $' rectSizeNorthEast��-
   $  SizeNESW��
������ $��5��$��5��$	��Top=�$��Right=��� $' rectSizeSouthWest��-   $  SizeNESW��
������ $��5��$��5��$��Bottom=�$
��Left=��� $' rectSizeSouthEast��-   $  SizeNWSE��
������ $��5��$��5��$��Bottom=�$��Right=� P�  �@�WindowState$ 	Maximized=�. ��� $	 PART_MaxButton_Path�� � ��| ��    ��- �@KL ��- �@KL  z �     z �    ��- �     	= �@KL  	= ���-     � z     � z @KL ���j @KL ���- @B � z @B 	P�  �@�IsActive .  . ��� $	 PART_Border��8   � ��( ���� '��       " ��) �� * �� *
IsActive+ �� $ WindowL�+ True.a���  � ��8  ��  � ��8  �� * �� *
IsActive+ �� $ WindowL�	+ False.a���  � ��8  ��  � ��8 	 