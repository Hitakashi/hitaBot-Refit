# hitaBot-Refit

How to use:

Create RestService with the Interface API you want to use:

``var rest = ServiceGenerator.createService<ChannelApi>();``

You can then use rest variables with it's methods to run a Web Connection, All Requests return a Task<T>

Known Issues:

Some methods return Task<Object>, You might be able to parse them with JSON.Net

Some methods return Task<string>, You can parse them with JSON.Net for now.

Missing models will be added later. 
