   M S B A M L   `   `   `  ����T  PVlaggen van de wereld 1.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Vlaggen_van_de_wereld_1._0Vlaggen_van_de_wereld_1._0  5   	   +    %Vlaggen_van_de_wereld_1._0.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Vlaggen_van_de_wereld_1._0     5   	     � Title$  Vlaggen van de wereld��5   	   $
��1375��6'   $	��800��67   $��0q�6G   ��.  � WindowStartupLocation$ CenterScreen=�6w   .��5	      �� -   5         ��Name$ MyScrollViewer��5	      $��0q�6+   $
��Auto=�66   $
��Auto=�6Y   $��0q�6~   $
��1050��6�   $	��550��6�   ��. .��5
   
   � -   5         �Name$ MyGrid��5
      $
��1250��6   $	��550��6/   $��0q�6?   $��Disabled=�6J   ��.  � RowDefinitions 5      �� 5      �� 5      $	��100 �6    .+�5      �� -   5         ��Name$ textBlock_title��5      $
��Left=�61   $��125,100,0,0q�6L   $
��Wrap=�6a   $��Vlaggen van de wereld��6u   $	��Top=�6�    J� RenderTransformOrigin$ 
0.505,1.25&�6�   $��50��6�   $
��Bold"�6�   $��30(�6�   �� 5      -   5         ��Name$ comboBox_selectNations��5      $
��Left=�67   $��125,210,0,0q�6R   $	��Top=�6g   $	��200��6   .@�5      �� -   5        $��Africa��5      $��Afrika��6-   �� 5      -   5        $
��Asia��5      $��Azië��6+   �� 5      -   5        $��Europe��5      $��Europa��6-   �� 5      -   5        $��NorthAmerica��5      $#��Noord-Amerika en de Caraïben��63   �� 5      -	   5        $��Oceania��5      $��Oceanië��6.   �� 5      -
   5        $��SouthAmerica��5      $��Zuid-Amerika��63   �� 5      -   5        $��World��5      $��Alle landen van de wereld��6,   5      �� 5      -   5        $ textBlock_selectNations��5      $
��Left=�69   $��125,179,0,0q�6T   $
��Wrap=�6i   $:��4Kies van welke landen je de nationale vlag wilt zien��6}   $	��Top=�6�   $ -0.303,0&�6�   $��22��6�   $��16(�6�   $	��375��6  �� 5      -   5        $ textBlock_toQuiz��5      $
��Left=�62   $��535,144,0,0q�6M   $
��Wrap=�6b   $��Of speel de ��6v   $	��Top=�6�   $��Comic Sans MS)�6�   $
��Bold"�6�   $��24(�6�   $	��175��6�   �� 5      -   5        $ textBlock_quiz��5      $
��Left=�60   $��562,170,0,0q�6K   $
��Wrap=�6`   $��VLAGGENQUIZ��6t   $	��Top=�6�   $��Comic Sans MS)�6�   $ 1.304,0.424&�6�   $
��Bold"�6�   $��30(�6�   
���  ��$	��250��6  $��	Underline{�6   � Cursor$
 Hand��6\  6�  �� 5      -   5        $# textBlock_selectedNationGroup��5      $
��Left=�6?   $��125,274,0,0q�6Z   $
��Wrap=�6o   $��Bekende vlaggen��6�   $	��Top=�6�   $��24(�6�   $��Segoe WP Semibold)�6�   �� 5      -   5        $ textBlock_quizQuestion��5      $
��Left=�68   $��550,340,0,0q�6S   $
��Wrap=�6h   $#��Van welk land is dit de vlag?��6|   $	��Top=�6�   $ -0.202,0.625&�6�   $��24(�6�   $��Segoe UI Semibold)�6�   $��32��6  $y�Hidden=�6  �� 5      -   5        $# textBlock_quizQuestionCounter��5      $
��Left=�6?   $��975,348,0,0q�6Z   $
��Wrap=�6o   $	��Top=�6�   $y�Hidden=�6�   $
��Bold"�6�   $��18(�6�   
�����p�$��Arial)�6�   �� 5      -   5        $% textBlock_numOfQuestionsCorrect��5      $
��Left=�6A   $��975,397,0,0q�6\   $
��Wrap=�6q   $��0  Goed��6�   $	��Top=�6�   $	��120��6�   
���"�"�$y�Hidden=�6�   
�������$��18(�6�   $
��Bold"�6  	 �� Padding$	 5q�6  
 �� TextAlignment$
 Center=�6$  $��SemiCondensed&�6;  �� 5       -   5        $# textBlock_numOfQuestionsWrong��5       $��1120,397,0,0q�6?   $
��Wrap=�6U   $��0  Fout��6i   $	��120��6x   
���<��$y�Hidden=�6�   
�������$��18(�6�   $
��Bold"�6�   $	 5q�6�   $
��Left=�6�   $	��Top=�6  $
 Center=�6  $��SemiCondensed&�66  �� 5!      -   5        $ textBlock_quizAnswer4��5!      $
��Left=�67   $��590,538,0,0q�6R   $
��Wrap=�6g   $��quizAnswer4��6{   $	��Top=�6�   $ 0.889,3.438&�6�   $y�Hidden=�6�   $��24(�6�   $��Segoe UI Semibold)�6�   
���  ����67  Z� 6�  �� 5"      -   5        $ textBlock_quizAnswer3��5"      $
��Left=�67   $��590,491,0,0q�6R   $
��Wrap=�6g   $��quizAnswer3��6{   $	��Top=�6�   $ 0.889,3.438&�6�   $y�Hidden=�6�   $��24(�6�   $��Segoe UI Semibold)�6�   
���  ��6w  �� 5#      -   5        $ textBlock_quizAnswer2��5#      $
��Left=�67   $��590,444,0,0q�6R   $
��Wrap=�6g   $��quizAnswer2��6{   $	��Top=�6�   $ 0.889,3.438&�6�   $y�Hidden=�6�   $��24(�6�   $��Segoe UI Semibold)�6�   
���  ��6v  �� 5$      -   5        $ textBlock_quizAnswer1��5$      $
��Left=�67   $��590,397,0,0q�6R   $
��Wrap=�6g   $��quizAnswer1��6{   $	��Top=�6�   $ 
0.69,3.446&�6�   $y�Hidden=�6�   $��24(�6�   $��Segoe UI Semibold)�6�   
���  ����66  Z� 6�  �� 5%      -   5        $! textBlock_quizAnswerNumber1��5%      $
��Left=�6=   $��550,397,0,0q�6X   $
��Wrap=�6m   $��A)��6�   $	��Top=�6�   $��24(�6�   $��25��6�   $��Segoe UI Semibold)�6�   $y�Hidden=�6�   
����iA�6�   �� 5&      -   5        $! textBlock_quizAnswerNumber2��5&      $
��Left=�6=   $��550,444,0,0q�6X   $
��Wrap=�6m   $��B)��6�   $	��Top=�6�   $��24(�6�   $��25��6�   $��Segoe UI Semibold)�6�   $y�Hidden=�6�   
����iA�6�   �� 5'      -   5        $! textBlock_quizAnswerNumber3��5'      $
��Left=�6=   $��550,491,0,0q�6X   $
��Wrap=�6m   $��C)��6�   $	��Top=�6�   $��24(�6�   $��25��6�   $��Segoe UI Semibold)�6�   $ 	0.4,1.906&�6�   $y�Hidden=�6�   
����iA�6  �� 5(      -   5        $! textBlock_quizAnswerNumber4��5(      $
��Left=�6=   $��550,538,0,0q�6X   $
��Wrap=�6m   $��D)��6�   $	��Top=�6�   $��24(�6�   $��35��6�   $��Segoe UI Semibold)�6�   $ 	0.4,1.906&�6�   $y�Hidden=�6�   
����iA�6  �� 5)      -   5        $  textBlock_quizAnswerResult��5)      $
��Left=�6<   $��550,600,0,0q�6W   $
��Wrap=�6l   $��	TextBlock��6�   $	��Top=�6�   $��18(�6�   $y�Hidden=�6�   �� 5*      -   5        $ textBlock_correctAnswer��5*      $
��Left=�69   $��550,600,0,0q�6T   $
��Wrap=�6i   $��	TextBlock��6}   $	��Top=�6�   $
��Bold"�6�   $��18(�6�   $y�Hidden=�6�   �� 5+      -   5        $  textBlock_showNextQuestion��5+      $
��Left=�6<   $��550,630,0,0q�6W   $
��Wrap=�6l   $��Toon volgende vlag��6�   $	��Top=�6�   $��18(�6�   $y�Hidden=�6�   
���  ��$
��Bold"�6�  ��6�   Z� 6�  �� 5,      -   5        $ textBlock_playAgainYes��5,      $
��Left=�68   $
 Center=�6S   $��550,685,0,0q�6j   $
��Wrap=�6   $��Ja��6�   $	��Top=�6�   $
��Bold"�6�   $y�Hidden=�6�   $��18(�6�   
�������
�������$	 5q�6  $��60��6  6�  �� 5-      -    5        $ textBlock_playAgainNo��5-      $
��Left=�67   $
 Center=�6R   $��630,685,0,0q�6i   $
��Wrap=�6~   $	��Nee��6�   $	��Top=�6�   $y�Hidden=�6�   $��18(�6�   $
��Bold"�6�   
�������
�������$	 5q�6  $��60��6  6�  �� 5.      -!   5         ��Name$ button_startNewQuiz��5.      $��Start nieuwe quiz��62   $
��Left=�6N   $��
975,50,0,0q�6i   $	��Top=�6}   $	��120��6�   
���iii�$y�Hidden=�6�   $��34��6�   $��3q�6�   
�������
�������6  �� 5/      -"   5        $ button_startViewingFlags��5/      $��Vlaggen bekijken��67   $
��Left=�6R   $��1120,50,0,0q�6m   $	��Top=�6�   $ 0.156,-0.964&�6�   
�������
���iii�$y�Hidden=�6�   $��34��6�   $	��120��6  
�������6.  50      51      52      