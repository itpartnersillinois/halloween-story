 # Archived Project -- IT Partners Readme.md file

 ## Summary: 
 This is for the 2020 Virtual Halloween party to be hosted on a MS Teams channel. Plus, I wanted to play with Blazor, and this provided me with a good opportunity. 

 ## Production location / dependencies: 

 It is on my dev Azure account, and I expect it to be shut down in November. 

 ## Development location / dependencies: 

 N/A

 ## How to deploy to production/development: 

 There's a publish profile to deploy this automatically. No CI/CD is set up. 

 ## How to set up locally: 

 Run. It requires a database connection for a single table. Here's the table definition:

      CREATE TABLE [dbo].[StoryItems](
	     [Id] [int] IDENTITY(1,1) NOT NULL,
      	[DateCreated] [datetime] NULL,
      	[Sentence] [varchar](max) NULL
      ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
      GO
      
      ALTER TABLE [dbo].[StoryItems] ADD  DEFAULT (getdate()) FOR [DateCreated]
      GO

 ## How to test (including unit tests): 

 N/A

 ## Notes (error logging, external tools, links, etc.):

 Note that there isn't any security around this.
