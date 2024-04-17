using EnterAiAgentEraDemos;;

Console.WriteLine("Agents rule!!");


//HandlebarsPipeline simpleSK = new HandlebarsPipeline();

//AgentCraftingMinion agentsExample = new();
//AgentCraftingMinion agentsExample = new();
AgentCreatorCritic agentsExample = new();

await agentsExample.Execute();

Console.WriteLine("Type enter to finish");
Console.ReadLine();