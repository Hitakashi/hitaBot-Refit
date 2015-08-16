# hitaBot-Refit

How to use:

Create RestService with the Interface API you want to use:

``var rest = ServiceGenerator.createService<ChannelApi>();``

You can then use rest variables with it's methods to run a Web Connection, All Requests return a Task&lt;T&gt;

Known Issues:

All APIs now return a Task&lt;T&gt;, Some of the more convoluted APIs will have a string inside the model which you'll have to parse. Most of these contain dynamic properties which makes it a tad hard to make a model out of it.
