   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBar.Static.Background  �� Color  ScrollBar.Static.Border  ScrollBar.Pressed.Glyph  ScrollBar.MouseOver.Glyph  ScrollBar.Disabled.Glyph  ScrollBar.Static.Glyph  FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray " ScrollBar.MouseOver.Background  ScrollBar.MouseOver.Border  	 ScrollBar.Pressed.Background 
 ScrollBar.Pressed.Border ! ScrollBar.Disabled.Background  ScrollBar.Disabled.Border  ScrollBarButton �� 
TargetType �� 
TargetType ��Name ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName  RepeatButtonTransparent  ScrollBar.MouseOver.Thumb  ScrollBar.Pressed.Thumb  ScrollBar.Static.Thumb  ScrollBarThumbVertical ��Name J� Opacity  ScrollBarThumbHorizontal �Name ]�Name J� IsMouseOver � 	Resources ]� DecreaseRepeatButton �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers �� PageLeftCommand �� PageRightCommand � Triggers :� RoutedEvent �� 
TargetName �� TargetProperty	 W� To  g� Duration! g� 	BeginTime" ��Name# �� CanContentScroll$ �� CanHorizontallyScroll% �� CanVerticallyScroll& ��Name4   .System.Windows.Automation.AutomationProperties'    AutomationId( � Cursor) �� ScrollableHeight* � Maximum+ � Minimum*, �� #ComputedVerticalScrollBarVisibility- �� ViewportHeight. �� ViewportSize/ � Value0 �� Mode1 �� RelativeSource2 �� ScrollableWidth3 �� Orientation,4 �� %ComputedHorizontalScrollBarVisibility5 �� ViewportWidth�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      1system&clr-namespace:System;assembly=mscorlib  5      %�  &	        &	 %     &	 F     &	 g     &	 �     &	 �     &	 �     &	 t    &	 �    &		 �    &	
 �    &	 �    &	     &	 :    7  7  7   7  7  7 	 7 
 7  7  &	 n    &	 �    &	 �    &	 �    &	     7  &	 l
    7  '�� �    7   7  7  7  7  7  7  7  '�� �    �� 5      $  Transparent��6:   �� 5      $  #F0F0F0��66   �� 5      $  #FFFFFF��66   �� 5      $  #000000��68   �� 5      $  #BFBFBF��67   �� 5	      $  #606060��65   �� 5
      .�5   
   ��  � �� 5      �� 5      .R�5      �� $��2q�6     . #��� ��6F   $��1��6�   $	 1 2R�6�   5      5      5      �� 5      $  #DADADA��6=   �� 5      $  #DADADA��69   �� 5      $  #606060��6;   �� 5      $  #606060��67   �� 5      $  #F0F0F0��6<   �� 5      $  #F0F0F0��68   �� 5      " ��6$   .�5   
   ��  �@�FocusVisualStyle8   6-   �� 5   
    � ��$ 1q�6,   �� 5   
    � ��$ Center=�67   �� 5   
    � ��$ Center=�65   �� 5   
    � ��$ 1q�6$   �� 5   
    � |� .  6&   �� 5    
    � �� .  6&   �� 5!   
    � �� 5"      �� 5#      " ��6"   .R�5$      �� $ border��6   8�� $��1q�6d   8��  . ._�5%      �� $ contentPresenter��6+   |�.  #��z��6W   #��z��6�   # z 6�   #��z��6�   5&      	 5'      P� 5(      
 �@J�IsMouseOver . . �5)      �� $ border��6;   8   � ��6O   �� 5*      $ border��6<   8   � ��6P   5+      P� 5,      
 � �� . . �5-      �� $ border��6;   8   � ��6O   �� 5.      $ border��6<   8   � ��6P   5/      P� 50      
 � {� .  . �51      �� $ contentPresenter��68    �@J�Opacity$
 0.56Q�6V   �� 52      $ border��6;   8   � ��6O   �� 53      $ border��6<   8   � ��6P   54      56      58      59      �� 5:      " ��6,   .�5;   
   ��  �@�OverridesDefaultStyle . 62   �� 5<   
    � ��
 ���� 6'   �� 5=   
    � |� .  6&   �� 5>   
    � �� .  6&   �� 5?   
    � �� 5@      �� 5A      " ��6"   .R�5B      �� #��z��6    #��z��6D   #��z��6f   5C      5E      5F      �� 5G      $  #A6A6A6��68   �� 5H      $  #606060��66   �� 5I      $  White��65   �� 5J      " n�6+   .�5K   
   ��  �@�OverridesDefaultStyle . 62   �� 5L   
    � �� .  6&   �� 5M   
    � �� 5N      �� 5O      " n�6"   .R�5P      � 
������ .+�5Q      �� $ 	rectangle��6$   8��  #��z��6f   $	 0.4Q�6�    . $��7��6�   $��Right=�6�   5R      	 5S      P� 5T      
 �@J�IsMouseOver . . �5U      �� $ 	rectangle��68    �@J�Opacity$	 0.7Q�6O   5V      P� 5W      
 �@n�
IsDragging . . �5X      �� $ 	rectangle��68    �@J�Opacity$	 0.7Q�6O   5Y      5[      5]      5^      �� 5_      " n�6-   .�5`   
   ��  �@�OverridesDefaultStyle . 62   �� 5a   
    � �� .  6&   �� 5b   
    � �� 5c      �� 5d      " n�6"   .R�5e      � 
������ .+�5f      �� $ 	rectangle��6$   8��  $	 0.4Q�6f   $��7��6t    . #��z��6�   $��Bottom=�6�   5g      	 5h      P� 5i      
 �@J�IsMouseOver . . �5j      �� $ 	rectangle��68    �@J�Opacity$	 0.7Q�6O   5k      P� 5l      
 �@n�
IsDragging . . �5m      �� $ 	rectangle��68    �@J�Opacity$	 0.7Q�6O   5n      5p      5r      5s      �� 5t      " ��6   .�5u   
   ��  �@��IsPressAndHoldEnabled .  69   �� 5v   
    �@��IsFlicksEnabled .  63   �� 5w   
    � ��8   6'   �� 5x   
    � ��8  6(   �� 5y   
    � ��# � ��6'   �� 5z   
    � ��$ 0q�6,   �� 5{   
    � ��$ 10��6"   �� 5|   
    �@J�Opacity$ 0Q�6$   �� 5}   
    � �� 5~      �� 5      " ��6"   .R�5�      � $ Bg��6    . .+�5�      ]� $ 
PART_Track��6    ��. #{�z 6O   $��1��6y    5�      ��X�5�   "   (��       60   *31SystemParameters.VerticalScrollBarButtonHeightKey+)100Q�5�   #   5�       5�      �� 5�   "   #��Z 6/   8�� 6\    5�      �� 5�   "   #��Z 6/   8�� 6^    5�      n� 5�   "   8�� 6(   5�      5�      5�      5�       5�   
   P� 5�      
 �@��Orientation$ 
Horizontal=�6-   . �5�      ��  � ��$
 Auto��6*   �� 5�       � ��$ 0��6-   �� 5�       � ��$ 10��6+   �� 5�       � ��$ 0q�64   �� 5�       � �� 5�      �� 5�      " ��6*   .R�5�      � $ Bg��6#    . .+�5�   "   ]� $ 
PART_Track��6(   $��1��6<   #{�z 6L    5�   &   ��X�5�   *   (��       68   *31SystemParameters.VerticalScrollBarButtonHeightKey+)100Q�5�   +   5�   '    5�   &   �� 5�   *   #��Z 67   8�� 6f    5�   &   �� 5�   *   #��Z 67   8�� 6g    5�   &   n� 5�   *   8�� 60   5�   #   5�      5�      5�      5�      5�      �� 5�      " ��6   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      � $
 Grid��6   #��z��6)    5�      :� 5�      $ 
MouseEnter��6+   .[�5�   "   �� .��5�   &   �� .��5�   *   W� $ PART_VerticalScrollBar��6:   $ Opacity�6i   $ 1X�6�   $  0:0:0.2D�6�   W� 5�   *   $ PART_HorizontalScrollBar��6:   $ Opacity�6k   $ 1X�6�   $  0:0:0.2D�6�   5�   '   5�   #   5�      :� 5�      $ 
MouseLeave��6+   .[�5�   "   �� .��5�   &   �� $! 0:0:0.5X�61   .��5�   *   W� $ PART_VerticalScrollBar��6:   $ Opacity�6i   $ 0X�6�   $  0:0:0.2D�6�   W� 5�   *   $ PART_HorizontalScrollBar��6:   $ Opacity�6k   $ 0X�6�   $  0:0:0.2D�6�   5�   '   5�   #   5�      .+�5�      �� $!" PART_ScrollContentPresenter��61   ## z��6V   $ .  % .  #��z��6�   #��z��6�   $��0��6  #��z��6.  $��0��6Q  �� 5�      $& PART_VerticalScrollBar��6$   $��Right=�6D   $' VerticalScrollBar��6`   $( Arrow��6�   $��1��6�   #* z) 6�   $+ 0Q�6�   $��0��6�   #y�z, 6�   #. z- 6�  / 6>  �� *VerticalOffset+$0 OneWay=�1 �� *TemplatedParent+6�  �� 5�      $& PART_HorizontalScrollBar��6$   $��Bottom=�6F   $' HorizontalScrollBar��6a   $( Arrow��6�   $��0��6�   #* z2 6�   $+ 0Q�6�   $3 
Horizontal=�6�   $��1��6	  #y�z4 6  #. z5 6�  / 6[  �� *HorizontalOffset+$0 OneWay=�1 �� *TemplatedParent+6�  5�      5�      5�      5�      5�      