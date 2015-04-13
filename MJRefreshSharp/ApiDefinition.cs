using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MJRefresh
{
    //    [Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern const CGFloat MJRefreshHeaderHeight;
        [Field("MJRefreshHeaderHeight")]
        nfloat MJRefreshHeaderHeight { get; }

        // extern const CGFloat MJRefreshFooterHeight;
        [Field("MJRefreshFooterHeight")]
        nfloat MJRefreshFooterHeight { get; }

        // extern const CGFloat MJRefreshFastAnimationDuration;
        [Field("MJRefreshFastAnimationDuration")]
        nfloat MJRefreshFastAnimationDuration { get; }

        // extern const CGFloat MJRefreshSlowAnimationDuration;
        [Field("MJRefreshSlowAnimationDuration")]
        nfloat MJRefreshSlowAnimationDuration { get; }

        // extern NSString *const MJRefreshHeaderUpdatedTimeKey;
        [Field("MJRefreshHeaderUpdatedTimeKey")]
        NSString MJRefreshHeaderUpdatedTimeKey { get; }

        // extern NSString *const MJRefreshContentOffset;
        [Field("MJRefreshContentOffset")]
        NSString MJRefreshContentOffset { get; }

        // extern NSString *const MJRefreshContentSize;
        [Field("MJRefreshContentSize")]
        NSString MJRefreshContentSize { get; }

        // extern NSString *const MJRefreshPanState;
        [Field("MJRefreshPanState")]
        NSString MJRefreshPanState { get; }

        // extern NSString *const MJRefreshHeaderStateIdleText;
        [Field("MJRefreshHeaderStateIdleText")]
        NSString MJRefreshHeaderStateIdleText { get; }

        // extern NSString *const MJRefreshHeaderStatePullingText;
        [Field("MJRefreshHeaderStatePullingText")]
        NSString MJRefreshHeaderStatePullingText { get; }

        // extern NSString *const MJRefreshHeaderStateRefreshingText;
        [Field("MJRefreshHeaderStateRefreshingText")]
        NSString MJRefreshHeaderStateRefreshingText { get; }

        // extern NSString *const MJRefreshFooterStateIdleText;
        [Field("MJRefreshFooterStateIdleText")]
        NSString MJRefreshFooterStateIdleText { get; }

        // extern NSString *const MJRefreshFooterStateRefreshingText;
        [Field("MJRefreshFooterStateRefreshingText")]
        NSString MJRefreshFooterStateRefreshingText { get; }

        // extern NSString *const MJRefreshFooterStateNoMoreDataText;
        [Field("MJRefreshFooterStateNoMoreDataText")]
        NSString MJRefreshFooterStateNoMoreDataText { get; }
    }

    // @interface MJRefresh (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefresh
    {
        // @property (readonly, nonatomic, strong) MJRefreshHeader * header;
        [Export("getheader")]
        MJRefreshHeader GetHeader();

        // @property (readonly, nonatomic) MJRefreshGifHeader * gifHeader;
        [Export("getgifHeader")]
        MJRefreshGifHeader GetGifHeader();

        // @property (readonly, nonatomic) MJRefreshLegendHeader * legendHeader;
        [Export("getlegendHeader")]
        MJRefreshLegendHeader GetLegendHeader();

        // -(MJRefreshLegendHeader *)addLegendHeaderWithRefreshingBlock:(void (^)())block;
        [Export("addLegendHeaderWithRefreshingBlock:")]
        MJRefreshLegendHeader AddLegendHeaderWithRefreshingBlock(Action block);

        // -(MJRefreshLegendHeader *)addLegendHeaderWithRefreshingBlock:(void (^)())block dateKey:(NSString *)dateKey;
        [Export("addLegendHeaderWithRefreshingBlock:dateKey:")]
        MJRefreshLegendHeader AddLegendHeaderWithRefreshingBlock(Action block, string dateKey);

        // -(MJRefreshLegendHeader *)addLegendHeaderWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("addLegendHeaderWithRefreshingTarget:refreshingAction:")]
        MJRefreshLegendHeader AddLegendHeaderWithRefreshingTarget(NSObject target, Selector action);

        // -(MJRefreshLegendHeader *)addLegendHeaderWithRefreshingTarget:(id)target refreshingAction:(SEL)action dateKey:(NSString *)dateKey;
        [Export("addLegendHeaderWithRefreshingTarget:refreshingAction:dateKey:")]
        MJRefreshLegendHeader AddLegendHeaderWithRefreshingTarget(NSObject target, Selector action, string dateKey);

        // -(MJRefreshGifHeader *)addGifHeaderWithRefreshingBlock:(void (^)())block;
        [Export("addGifHeaderWithRefreshingBlock:")]
        MJRefreshGifHeader AddGifHeaderWithRefreshingBlock(Action block);

        // -(MJRefreshGifHeader *)addGifHeaderWithRefreshingBlock:(void (^)())block dateKey:(NSString *)dateKey;
        [Export("addGifHeaderWithRefreshingBlock:dateKey:")]
        MJRefreshGifHeader AddGifHeaderWithRefreshingBlock(Action block, string dateKey);

        // -(MJRefreshGifHeader *)addGifHeaderWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("addGifHeaderWithRefreshingTarget:refreshingAction:")]
        MJRefreshGifHeader AddGifHeaderWithRefreshingTarget(NSObject target, Selector action);

        // -(MJRefreshGifHeader *)addGifHeaderWithRefreshingTarget:(id)target refreshingAction:(SEL)action dateKey:(NSString *)dateKey;
        [Export("addGifHeaderWithRefreshingTarget:refreshingAction:dateKey:")]
        MJRefreshGifHeader AddGifHeaderWithRefreshingTarget(NSObject target, Selector action, string dateKey);

        // -(void)removeHeader;
        [Export("removeHeader")]
        void RemoveHeader();

        // @property (readonly, nonatomic, strong) MJRefreshFooter * footer;
        [Export("getfooter")]
        MJRefreshFooter GetFooter();

        // @property (readonly, nonatomic) MJRefreshGifFooter * gifFooter;
        [Export("getgifFooter")]
        MJRefreshGifFooter GetGifFooter();

        // @property (readonly, nonatomic) MJRefreshLegendFooter * legendFooter;
        [Export("getlegendFooter")]
        MJRefreshLegendFooter GetLegendFooter();

        // -(MJRefreshLegendFooter *)addLegendFooterWithRefreshingBlock:(void (^)())block;
        [Export("addLegendFooterWithRefreshingBlock:")]
        MJRefreshLegendFooter AddLegendFooterWithRefreshingBlock(Action block);

        // -(MJRefreshLegendFooter *)addLegendFooterWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("addLegendFooterWithRefreshingTarget:refreshingAction:")]
        MJRefreshLegendFooter AddLegendFooterWithRefreshingTarget(NSObject target, Selector action);

        // -(MJRefreshGifFooter *)addGifFooterWithRefreshingBlock:(void (^)())block;
        [Export("addGifFooterWithRefreshingBlock:")]
        MJRefreshGifFooter AddGifFooterWithRefreshingBlock(Action block);

        // -(MJRefreshGifFooter *)addGifFooterWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("addGifFooterWithRefreshingTarget:refreshingAction:")]
        MJRefreshGifFooter AddGifFooterWithRefreshingTarget(NSObject target, Selector action);

        // -(void)removeFooter;
        [Export("removeFooter")]
        void RemoveFooter();
    }

    // @interface MJRefreshDeprecated (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefreshDeprecated
    {
        // -(void)addHeaderWithCallback:(void (^)())callback __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendHeaderWithRefreshingBlock:]")]
        [Export("addHeaderWithCallback:")]
        void AddHeaderWithCallback(Action callback);

        // -(void)addHeaderWithCallback:(void (^)())callback dateKey:(NSString *)dateKey __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendHeaderWithRefreshingBlock:dateKey:]")]
        [Export("addHeaderWithCallback:dateKey:")]
        void AddHeaderWithCallback(Action callback, string dateKey);

        // -(void)addHeaderWithTarget:(id)target action:(SEL)action __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendHeaderWithRefreshingTarget:refreshingAction:]")]
        [Export("addHeaderWithTarget:action:")]
        void AddHeaderWithTarget(NSObject target, Selector action);

        // -(void)addHeaderWithTarget:(id)target action:(SEL)action dateKey:(NSString *)dateKey __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendHeaderWithRefreshingTarget:refreshingAction:dateKey:]")]
        [Export("addHeaderWithTarget:action:dateKey:")]
        void AddHeaderWithTarget(NSObject target, Selector action, string dateKey);

        // -(void)headerBeginRefreshing __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用[self.tableView.header beginRefreshing]]")]
        [Export("headerBeginRefreshing")]
        void HeaderBeginRefreshing();

        // -(void)headerEndRefreshing __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用[self.tableView.header endRefreshing]]")]
        [Export("headerEndRefreshing")]
        void HeaderEndRefreshing();

        // @property (getter = isHeaderHidden, assign, nonatomic) BOOL headerHidden;
        [Export("isHeaderHidden")]
        bool IsHeaderHidden();

        [Export("setHeaderHidden")]
        void SetHeaderHidden(bool value);

        // @property (readonly, getter = isHeaderRefreshing, assign, nonatomic) BOOL headerRefreshing;
        [Export("isHeaderRefreshing")]
        bool IsHeaderRefreshing();

        [Export("setHeaderRefreshing")]
        void SetHeaderRefreshing(bool value);

        // -(void)addFooterWithCallback:(void (^)())callback __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendFooterWithRefreshingBlock:]")]
        [Export("addFooterWithCallback:")]
        void AddFooterWithCallback(Action callback);

        // -(void)addFooterWithTarget:(id)target action:(SEL)action __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用addLegendFooterWithRefreshingTarget:refreshingAction:]")]
        [Export("addFooterWithTarget:action:")]
        void AddFooterWithTarget(NSObject target, Selector action);

        // -(void)footerBeginRefreshing __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用[self.tableView.footer beginRefreshing]]")]
        [Export("footerBeginRefreshing")]
        void FooterBeginRefreshing();

        // -(void)footerEndRefreshing __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用[self.tableView.footer endRefreshing]]")]
        [Export("footerEndRefreshing")]
        void FooterEndRefreshing();

        // @property (getter = isFooterHidden, assign, nonatomic) BOOL footerHidden;
        //        [Availability(Introduced = Platform.iOS_2_0, Deprecated = Platform.iOS_2_0, Message = "[Sharpie.Clang.Ast.IdentifierInfo: 建议使用self.tableView.footer.hidden]")]
        //        [Export("footerHidden")]
        //        bool FooterHidden { [Bind ("isFooterHidden")] get; set; }
        [Export("isFooterHidden")]
        bool IsFooterHidden();

        [Export("setFooterHidden")]
        void SetFooterHidden(bool value);

        // @property (readonly, getter = isFooterRefreshing, assign, nonatomic) BOOL footerRefreshing;
        [Export("isFooterRefreshing")]
        bool IsFooterRefreshing();

        [Export("setFooterRefreshing")]
        void SetFooterRefreshing(bool value);
    }

    // @interface MJRefreshComponent : UIView
    [BaseType(typeof(UIView))]
    interface MJRefreshComponent
    {
        //        UIEdgeInsets _scrollViewOriginalInset;

        //        [unsupported Attributed: UIScrollView *__weak] _scrollView;

        // @property (nonatomic, strong) UIColor * textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, strong) UIFont * font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (copy, nonatomic) void (^refreshingBlock)();
        [Export("refreshingBlock", ArgumentSemantic.Copy)]
        Action RefreshingBlock { get; set; }

        // -(void)setRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("setRefreshingTarget:refreshingAction:")]
        void SetRefreshingTarget(NSObject target, Selector action);

        // @property (nonatomic, weak) id refreshingTarget;
        [Export("refreshingTarget", ArgumentSemantic.Weak)]
        NSObject RefreshingTarget { get; set; }

        // @property (assign, nonatomic) SEL refreshingAction;
        [Export("refreshingAction", ArgumentSemantic.Assign)]
        Selector RefreshingAction { get; set; }

        // -(void)beginRefreshing;
        [Export("beginRefreshing")]
        void BeginRefreshing();

        // -(void)endRefreshing;
        [Export("endRefreshing")]
        void EndRefreshing();

        // -(BOOL)isRefreshing;
        [Export("isRefreshing")]
        //        [Verify(MethodToProperty)]
        bool IsRefreshing { get; }
    }

    // @interface MJRefreshHeader : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshHeader
    {
        // @property (copy, nonatomic) NSString * dateKey;
        [Export("dateKey")]
        string DateKey { get; set; }

        // @property (copy, nonatomic) NSString * (^updatedTimeTitle)(NSDate *);
        [Export("updatedTimeTitle", ArgumentSemantic.Copy)]
        Func<NSDate, NSString> UpdatedTimeTitle { get; set; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshHeaderState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshHeaderState state);

        // @property (assign, nonatomic) MJRefreshHeaderState state;
        [Export("state", ArgumentSemantic.Assign)]
        MJRefreshHeaderState State { get; set; }

        // @property (getter = isStateHidden, assign, nonatomic) BOOL stateHidden;
        [Export("stateHidden")]
        bool StateHidden { [Bind ("isStateHidden")] get; set; }

        // @property (getter = isUpdatedTimeHidden, assign, nonatomic) BOOL updatedTimeHidden;
        [Export("updatedTimeHidden")]
        bool UpdatedTimeHidden { [Bind ("isUpdatedTimeHidden")] get; set; }

        // @property (assign, nonatomic) CGFloat pullingPercent;
        [Export("pullingPercent", ArgumentSemantic.Assign)]
        nfloat PullingPercent { get; set; }
    }

    // @interface MJRefreshGifHeader : MJRefreshHeader
    [BaseType(typeof(MJRefreshHeader))]
    interface MJRefreshGifHeader
    {
        // -(void)setImages:(NSArray *)images forState:(MJRefreshHeaderState)state;
        [Export("setImages:forState:")]
        //        [Verify(StronglyTypedNSArray)]
        void SetImages(UIImage[] images, MJRefreshHeaderState state);
    }

    // @interface MJRefreshLegendHeader : MJRefreshHeader
    [BaseType(typeof(MJRefreshHeader))]
    interface MJRefreshLegendHeader
    {
    }

    // @interface MJRefreshFooter : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshFooter
    {
        // -(void)noticeNoMoreData;
        [Export("noticeNoMoreData")]
        void NoticeNoMoreData();

        // -(void)resetNoMoreData;
        [Export("resetNoMoreData")]
        void ResetNoMoreData();

        // @property (assign, nonatomic) MJRefreshFooterState state;
        [Export("state", ArgumentSemantic.Assign)]
        MJRefreshFooterState State { get; set; }

        // @property (getter = isStateHidden, assign, nonatomic) BOOL stateHidden;
        [Export("stateHidden")]
        bool StateHidden { [Bind ("isStateHidden")] get; set; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshFooterState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshFooterState state);

        // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
        [Export("automaticallyRefresh")]
        bool AutomaticallyRefresh { [Bind ("isAutomaticallyRefresh")] get; set; }

        // @property (assign, nonatomic) CGFloat appearencePercentTriggerAutoRefresh;
        [Export("appearencePercentTriggerAutoRefresh", ArgumentSemantic.Assign)]
        nfloat AppearencePercentTriggerAutoRefresh { get; set; }
    }

    // @interface MJRefreshGifFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshGifFooter
    {
        // @property (nonatomic, strong) NSArray * refreshingImages;
        [Export("refreshingImages", ArgumentSemantic.Strong)]
        //        [Verify(StronglyTypedNSArray)]
        UIImage[] RefreshingImages { get; set; }
    }

    // @interface MJRefreshLegendFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshLegendFooter
    {
    }

    // @interface MJExtension (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJExtension
    {
        // @property (assign, nonatomic) CGFloat mj_insetT;
        [Export("getmj_insetT")]
        nfloat GetMj_insetT();

        [Export("setmj_insetT")]
        void SetMj_insetT(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_insetB;
        [Export("getmj_insetB")]
        nfloat GetMj_insetB();

        [Export("setmj_insetB")]
        void SetMj_insetB(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_insetL;
        [Export("getmj_insetL")]
        nfloat GetMj_insetL();

        [Export("setmj_insetL")]
        void SetMj_insetL(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_insetR;
        [Export("getmj_insetR")]
        nfloat GetMj_insetR();

        [Export("setmj_insetR")]
        void SetMj_insetR(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_offsetX;
        [Export("getmj_offsetX")]
        nfloat GetMj_offsetX();

        [Export("setmj_offsetX")]
        void SetMj_offsetX(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_offsetY;
        [Export("getmj_offsetY")]
        nfloat GetMj_offsetY();

        [Export("setmj_offsetY")]
        void SetMj_offsetY(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_contentSizeW;
        [Export("getmj_contentSizeW")]
        nfloat GetMj_contentSizeW();

        [Export("setmj_contentSizeW")]
        void SetMj_contentSizeW(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_contentSizeH;
        [Export("getmj_contentSizeH")]
        nfloat GetMj_contentSizeH();

        [Export("setmj_contentSizeH")]
        void SetMj_contentSizeH(nfloat value);

    }

    // @interface MJExtension (UIView)
    [Category]
    [BaseType(typeof(UIView))]
    interface UIView_MJExtension
    {
        // @property (assign, nonatomic) CGFloat mj_x;
        [Export("getmj_x")]
        nfloat GetMj_X();

        [Export("setmj_x")]
        void SetMj_X(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_y;
        [Export("getmj_y")]
        nfloat GetMj_Y();

        [Export("setmj_y")]
        void SetMj_Y(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_w;
        [Export("getmj_w")]
        nfloat GetMj_W();

        [Export("setmj_w")]
        void SetMj_W(nfloat value);

        // @property (assign, nonatomic) CGFloat mj_h;
        [Export("getmj_h")]
        nfloat GetMj_H();

        [Export("setmj_h")]
        void SetMj_H(nfloat value);

        // @property (assign, nonatomic) CGSize mj_size;
        [Export("getmj_size")]
        CGSize GetMj_Size();

        [Export("setmj_size")]
        void SetMj_Size(CGSize value);

        // @property (assign, nonatomic) CGPoint mj_origin;

        [Export("getmj_origin")]
        CGPoint GetMj_Origin();

        [Export("setmj_origin")]
        void SetMj_Origin(CGPoint value);
    }
}
