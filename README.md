# Megarobo-KunPengLIMS

#### 介绍
鲲鹏LIMS后端项目

#### 软件架构
由一个解决方案包含4个子项目：
Megarobo.KunPengLIMS.WebAPI：是一个WebAPI项目，访问/swagger/index.html可以查看API文档，包含Dockerfile。
Megarobo.KunPengLIMS.Application：是一个应用层的dll类库项目，主要包括应用服务和DTO定义
Megarobo.KunPengLIMS.Domain：是一个领域层的dll类库项目，主要包括领域实体定义和仓储接口定义
Megarobo.KunPengLIMS.Infrastructure：是一个基础设施层的dll类库项目，主要包括数据库迁移文件和仓储实现


#### 安装教程
使用Docker构建：
1 需要确保dotnet core环境：docker pull mcr.microsoft.com/dotnet/aspnet:3.1
2 构建：docker build -f "D:\MegaRobo\PMS\LIMS\KunPengLIMS\Megarobo.KunPengLIMS\Megarobo.KunPengLIMS.WebAPI\Dockerfile" -t megarobokunpenglimswebapi:dev  "D:\MegaRobo\PMS\LIMS\KunPengLIMS\Megarobo.KunPengLIMS" 


#### 使用说明

1.  xxxx
2.  xxxx
3.  xxxx

#### 参与贡献

1.  Fork 本仓库
2.  新建 Feat_xxx 分支
3.  提交代码
4.  新建 Pull Request


#### 特技

1.  使用 Readme\_XXX.md 来支持不同的语言，例如 Readme\_en.md, Readme\_zh.md
2.  Gitee 官方博客 [blog.gitee.com](https://blog.gitee.com)
3.  你可以 [https://gitee.com/explore](https://gitee.com/explore) 这个地址来了解 Gitee 上的优秀开源项目
4.  [GVP](https://gitee.com/gvp) 全称是 Gitee 最有价值开源项目，是综合评定出的优秀开源项目
5.  Gitee 官方提供的使用手册 [https://gitee.com/help](https://gitee.com/help)
6.  Gitee 封面人物是一档用来展示 Gitee 会员风采的栏目 [https://gitee.com/gitee-stars/](https://gitee.com/gitee-stars/)
