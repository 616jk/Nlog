# Nlog

NLog is a flexible and free logging platform for various .NET platforms, including .NET standard. NLog makes it easy to write to several targets. (database, file, console) and change the logging configuration on-the-fly.

- NLog: https://nlog-project.org/
- Basic Understanding Of NLog: https://www.c-sharpcorner.com/article/basic-understanding-of-nlog/
- Configuration options > Targets: https://nlog-project.org/config/?tab=targets
- Database Targets: https://github.com/NLog/NLog/wiki/Database-target

#### *Note: this is just a sample project as a reference*

___

#### Tools:
- Microsoft SQL Server Management Studio
- Visual Studio 2019

#### Steps:
1. Create database - TEST_DB
2. Create log table

        SET ANSI_NULLS ON
        SET QUOTED_IDENTIFIER ON
        CREATE TABLE [dbo].[Log] (
          [Id] [int] IDENTITY(1,1) NOT NULL,
          [Logged] [datetime] NOT NULL,
          [Level] [nvarchar](50) NOT NULL,
          [Message] [nvarchar](max) NOT NULL,
          [Logger] [nvarchar](250) NULL,
          [Callsite] [nvarchar](max) NULL,
          [Exception] [nvarchar](max) NULL,
          CONSTRAINT [PK_dbo.Log] PRIMARY KEY CLUSTERED ([Id] ASC)
            WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
        ) ON [PRIMARY]

3. Open the project "Nlog" with Visual Studio 2019
4. Open the file NLog.config - change the fileName to your path.
    > fileName="C:\Git\Nlog\Logs\NLog_${date:format=yyyyMMdd}.log"
5. Run the project and you can see the log file and database.


#### Youtube: 
visual studio 2019 c# Nlog


#### Screenshot:

- Console
  ![Console](https://raw.githubusercontent.com/616jk/Nlog/main/screenshot_console.png)

- File
  ![File](https://raw.githubusercontent.com/616jk/Nlog/main/screenshot_file.png)

- Database
  ![Database](https://raw.githubusercontent.com/616jk/Nlog/main/screenshot_database.png)
