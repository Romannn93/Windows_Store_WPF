   M S B A M L   `   `   `  ????L  HWindowsStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:WindowsStoreClone.PagesWindowsStoreClone.Pages  5      O,clr-namespace:WindowsStoreClone.UserControlsWindowsStoreClone.UserControls  5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      "    WindowsStoreClone.Pages.Main   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:WindowsStoreClone.Pages     5      ;uc,clr-namespace:WindowsStoreClone.UserControls     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        N? Title$
  Main??5      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??40 ?6   6*   ?? 5      $??* ?6   6)    ? ColumnDefinitions 5   
   ?? 5      $??35 ?6   6,   ?? 5      $
??0.6* ?6   6.   ?? 5      $
??0.4* ?6   6.   ?? 5      $??35 ?6   6,   .+?5   
   =  7MahApps.Metro.Controls.MetroAnimatedSingleRowTabControl  -   5          Name$ MainTabControl??5      $y?Visible=?5      $??0??5      $??1??6   $??2??5      $??2??5      }?. .@?5       ?? -   5        $??HomeTab??5    $   $
??Home??6   .??5!      ?? -   5        $??MainScrollViewer??5!      $??10q?5"      $??Hidden=?5#      $??Hidden=?5$      .??5'      ?? -   5        $??MainHomeStackPanel??5(      $	??Top=?5)      $
??Left=?5*      $y?Visible=?5+      ??5,      ??  ?? ElementName$ MainScrollViewer?? ?? Path$ ActualWidth?.+?5-      ,   &WindowsStoreClone.UserControls.TopApps  -   5          Name$ TopApps??5-   %   $
??Left=?5.   %   $??2q?50   %   ??5/   %   ?? $ MainTabControl??$ ActualWidth?50   %   ?? 51      $
??Left=?52      $??10,10,10,10q?53      $??Featured apps??54      $??40(?55      /   )WindowsStoreClone.UserControls.AppsViewer  57      -   5          Name$ FeaturesAppsViewer??57   (   $
??Left=?58   (   $??2q?5:   )   ??59   )   ?? $ MainScrollViewer??$ ActualWidth?5:   )   ?? 5;      $
??Left=?5<      $??10,10,10,10q?5=      $??Most popular??5>      $??40(?5?        5A      -   5        $ MostPopularAppsViewer??5A   (   $
??Left=?5B   (   $??2q?5D   )   ??5C   )   ?? $ MainScrollViewer??$ ActualWidth?5D   )   ?? 5E      $
??Left=?5F      $??10,10,10,10q?5G      $??Top free apps??5H      $??40(?5I        5K      -   5        $ TopFreeAppsViewer??5K   (   $
??Left=?5L   (   $??2q?5N   )   ??5M   )   ?? $ MainScrollViewer??$ ActualWidth?5N   )   ?? 5O      $
??Left=?5P      $??10,10,10,10q?5Q      $??Top free games??5R      $??40(?5S        5U      -	   5        $ TopFreeGamesViewer??5U   (   $
??Left=?5V   (   $??2q?5X   )   ??5W   )   ?? $ MainScrollViewer??$ ActualWidth?5X   )   5Y      5Z      5[      ?? 5]      $??Gaming??6   .??5^      ?? .+?5_      ?? $
??Left=?5`      $??10,10,10,10q?5a      $??Top free games??5b      $??40(?5c        5e      -
   5        $ GamingAppsViewer??5e   $   $
??Left=?5f   %   ??5g   %   ?? $ MainTabControl??$ ActualWidth?5h      5i      ?? 5k      $??Entertainment??6   .??5l      ?? .+?5m      ?? $
??Left=?5n      $??10,10,10,10q?5o      $??Top free apps??5p      $??40(?5q        5s      -   5        $ EntertainmentAppsViewer??5s   $   $
??Left=?5t   %   ??5u   %   ?? $ MainTabControl??$ ActualWidth?5v      5w      ?? 5x      $??Productivity??6   .??5y      ?? -   5        $??MainProductivitySV??5y      $??10q?5z      $??Hidden=?5{      $??Hidden=?5|      .??5~      ?? -   5        $??MainProductuctivitySP??5~   !   ??5   !   ?? $ MainProductivitySV??$ ActualWidth?.+?5?      8   2WindowsStoreClone.UserControls.ProductivityTopApps  -   5          Name$ ProductivityTopApps??5?   1   ??5?      ?? $ MainProductivitySV??$ ActualWidth??? 5?      $
??Left=?5?      $??10,10,10,10q?5?      $??App specials??5?      $??40(?5?        5?      -   5        $ ProductivityAppsL1??5?   (   $
??Left=?5?   %   ??5?   %   ?? $ MainProductivitySP??$ ActualWidth??? 5?      $
??Left=?5?      $??10,10,10,10q?5?      $??Best selling apps??5?      $??40(?5?        5?      -   5        $ ProductivityAppsL2??5?   (   $
??Left=?5?   %   ??5?   %   ?? $ MainProductivitySP??$ ActualWidth??? 5?      $
??Left=?5?      $??10,10,10,10q?5?      $??Favourite apps??5?      $??40(?5?        5?      -   5        $ ProductivityAppsL3??5?   (   $
??Left=?5?   %   ??5?   %   ?? $ MainTabControl??$ ActualWidth?5?      5?      5?      ?? 5?      $??Deals??6   .??5?      ?? .+?5?      ?? $
??Left=?5?      $??Apps specials??5?      $??40(?5?        5?      -   5        $ DealsAppsViewer??5?   $   $
??Left=?5?   %   ??5?   %   ?? $ MainTabControl??$ ActualWidth?5?      5?      5?      7   1WindowsStoreClone.UserControls.HeaderRightButtons  5?   
   -   5        	  Name$	 RightHeaderButtons??5?      $??0??5?      $??2??5?      $??1??5?      5?      5?      