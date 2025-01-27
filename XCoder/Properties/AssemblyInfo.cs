﻿using System.Reflection;
using System.Runtime.InteropServices;

// 有关程序集的常规信息通过下列属性集
// 控制。更改这些属性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("新生命码神工具")]
[assembly: AssemblyDescription("基于编译型模版引擎的代码生成器，以及众多开发者工具")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("XCoder")]
[assembly: AssemblyCompany("新生命开发团队")]
[assembly: AssemblyCopyright("©2002-2018 新生命开发团队 http://www.NewLifeX.com")]
[assembly: AssemblyTrademark("四叶草")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 使此程序集中的类型
// 对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型，
// 则将该类型上的 ComVisible 属性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("bfff5d5b-dd0d-4464-b7b8-ec3786bc2d7b")]

// 程序集的版本信息由下面四个值组成:
//
//      主版本
//      次版本 
//      内部版本号
//      修订号
//
[assembly: AssemblyVersion("7.0.*")]
[assembly: AssemblyFileVersion("7.0.2019.0707")]

/*
 * v6.9.2017.0101   增加消息调试工具，支持调试网络库的消息收发功能
 * 
 * v6.9.2016.0504   增加操作语音提示和语音识别辅助操作
 * 
 * v6.7.2016.0418   异步加载子工具，支持外部FrmMain窗体
 * 
 * v6.6.2016.0205   升级网络调试工具，增加收发数据的日志控制，增加统计信息
 * 
 * v6.5.2015.0701   升级自动更新机制，从网站自动更新
 * 
 * v6.4.2015.0519   改进串口调试工具，显示设备友好名
 * 
 * v6.3.2015.0511   改进网络调试工具，列出网络库的所有网络服务器
 * 
 * v6.2.2014.1225   增加网络调试工具，支持TCP/UDP混合，支持内置基础网络服务协议解析
 * 
 * v6.1.2014.0907   串口工具XCOM以十六进制输出时，可以选择是否自动换行
 * 
 * v6.1.2014.0607   串口工具XCOM，自动检测到串口断开时，断开串口连接，避免内存溢出
 * 
 * v6.0.2014.0514   使用模版文件本身的文件编码来作为输出文件的编码，默认UTF8
 * 
 * v6.0.2014.0419   打开码神工具时，默认打开最后一次打开的工具，由配置据诶的那个而不是由名称决定
 *                  重构串口调试工具，简约风格
 * 
 * v6.0.2014.0410   根据文件名决定XCoder打开哪个工具
 * 
 * v6.0.2013.1211   命令行调用XCoder生成代码支持指定日志文件路径
 * 
 * v6.0.2013.0919   合并数据建模工具、正则测试工具、通讯调试工具、图标水印处理工具
 * 
 * v5.1.2013.0906   更新扩展查询模版，默认的FindByxx/FindAllByxx函数里面，缓存查找采用__.xx名称，而不要用_.xx，后面默认得到字段名，不适合内存查找
 * 
 * v5.1.2013.0307   增强数据模型，生成代码时可使用$(属性名)作为输出路径的一部分，支持IDataTable的属性和扩展属性（主要）
 * 
 * v5.0.2012.1117   增加T4引导模版，用于在实体类项目中通过命令行调用XCoder生成代码
 * 
 * v4.9.2012.1112   数据模型升级，需要更新所有模版
 *                  模版引擎生成太快，不再需要后台生成
 *                  改变模版头编辑的位置
 *                  增加论坛帖子引用
 * 
 * v4.8.2012.0731   升级前备份配置文件，升级后恢复
 * 
 * v4.8.2012.0526   支持自动探测SqlCe数据库
 * 
 * v4.8.2012.0516   采用新的数据模型格式化架构，优化表名及字段名的生成
 * 
 * v4.7.2012.0320   调整拥挤的主界面，删除不需要的元素
 *                  调整自动更新，支持组件和源代码的同步升级
 * 
 * v4.6.2012.0113   代码生成器提供生成建表语句，建库语句，还有直接建库的功能
 * 
 * v4.5.2011.1108   配合实体访问器和CommonEntity，增加第三代管理页面模版
 * 
 * v4.4.2011.1031   增加查询分析器
 * 
 * v4.3.2011.0920   将在线翻译服务替换成s.nnhy.org上的翻译服务
 * 
 * v4.3.2011.0915   增加数据表架构，比如Access，可以从中识别字段是否自增
 * 
 * v4.3.2011.0913   增加是否生成泛型实体类的设置
 * 
 * v4.2.2011.0911   分离架构信息管理和模型管理，允许编辑模型
 * 
 * v4.2.2011.0909   支持内部模版，也支持外部文件模版，支持释放内部模版
 * 
 * v4.2.2011.0908   修正代码生成时更改输出目录后无效的BUG
 *                  完善各个模版
 *                  更改模版存放方式，直接从嵌入资源读取，不再释放
 *                  增加一个设置项Config.BaseClass，允许指定实体类的基类
 *                  增加数据架构管理功能
 * 
 * v4.1.2011.0906   修正生成时不能自动创建输出目录的错误
 *                  数据表选择支持显示中文描述
 * 
 * v4.1.2011.0902   修改自动更新逻辑，先下载，再询问是否更新
 *                  改善自动发现机制，自动发现本地SQLite和Access文件
 *                  增加自动在线翻译功能，调用Bing翻译
 * 
 * v4.0.2011.0829   升级XCode到v8
 *                  增加自动更新功能
 *                  删除代码视图
 *                  集成www.7765.com在线音乐
 * 
 * v3.4.2011.0329   修正自动尝试加载表时的错误
 *                  更新实体模版，以兼容最新版本的XCode v7.5
 * 
 * v3.4.2011.0316   升级模版引擎XTemplate，大大提高模版处理性能
 * 
 * v3.4.2011.0311   XCode升级到最新版本，增加数据库支持
 * 
 * v3.3.2011.0117   增加实体模版和页面模版，改变以前的生成模式（由一个表四次改为两次）
 *                  使用新的控件GridViewExtend和自定义表单EntityForm
 * 
 * v3.2.2010.1014   增加是否使用文件模版头的设置
 *                  更新模版引擎到v1.3，取消对模版的换行优化处理
 *                  增加第二套表单模版
 * 
 * v3.1.2010.1009   增加文件头
 *                  使用新的模版引擎
 * 
 * v3.0.2010.0928   更新模版引擎
 * 
 * v2.4.2010.0128   增加等号支持
 * 
 * v2.3.2009.1013   XCode数据架构升级
 * 
 * v2.2.2009.0714   修正待替换内容（如默认值）含有双引号而待替换标签前后又有双引号时，没有正确处理双引号的问题
 * 
 * v2.1.2009.0623   增加对Oracle的支持
 * 
 * v2.0.2009.0611   增加中文文件名配置，直接生成中文文件名的类
 *                  每次生成表时，重新从数据库取构架信息
 * 
 * v1.9.2009.0519   处理以类名开头的属性名后，再次纠正属性名
 * 
 * v1.8.2009.0330   属性名等于类名时，自动增加后缀0
 *                  属性名等于item时，自动增加后缀0
 *                  属性名以类名开头时，自动去除
 *                  代码查看框随着窗体最大化自动扩展
 *                  修正链接名错误使用当前链接名而不是填写的链接名的错误
 * 
 * v1.7.2009.0321   加载所有表时，按表名排序
 *
**/
