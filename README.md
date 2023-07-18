# OpcUaClient

This is a project that represents OPC UA client that is made with C# programming language and Windows Forms desktop GUI technology. 
The purpose of project is to connect to every OPC UA server, it desn't matter if it is local server or remote server. There is a 
confuguration JSON file in which the client must setup the URL to the server, the Root Node Id and (it is NOT mandatory) all node ids
that the cliet wants to see in the datagrid view. This config option is because in some cases the client wants to see only the nodes
that are interesting for him/her. It is added automated subscription (refresh for 1 sec) for each of nodes that client shows.

NOTE: The two things that are mandatory for the proper working of application are to be set server URL and to be set the Root Node Id. 
In the next versions of the app, probably the root node setting will be removed.
NOTE: All nodes are configured to get almost immediate the latest value for the node.

/App/:
![app](https://github.com/velizar92/OpcUaClient/assets/40525254/c50bbce5-bf37-433f-a48f-a855b779d619)


/Configuration File/:

![conf](https://github.com/velizar92/OpcUaClient/assets/40525254/1f47d228-7053-4b7b-b6cf-54cfdce39d32)

/Initial View/:

![InitScreen](https://github.com/velizar92/OpcUaClient/assets/40525254/99030fa2-1fac-4b7e-b15f-ed36e33a4a59)

/Showed Configured Nodes after pressing of Connect button/ -> On the right side is opened the configuration JSON file

![ShowingOfConfiguredNodesInGrid](https://github.com/velizar92/OpcUaClient/assets/40525254/5e3ff448-8325-4714-a7bc-4886930405fe)

/Showed the children nodes of selected node in the TreeView/ -> The children nodes are shown in the datagrid view

![ShowingOfSelectedNodeChildren](https://github.com/velizar92/OpcUaClient/assets/40525254/993ffd23-8011-45b9-a527-52483c20922f)

/Showing of complex node value/ -> Complex node means object from some type but not primitive type.
The second view shows all properties of the certain object and their values

![ComplexNodeShowingForm](https://github.com/velizar92/OpcUaClient/assets/40525254/5b3f7d83-f53e-430f-99e4-c050ae372686)

UI components:

  1. "Connect" Button - connects the client to the server  ![ConnectBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/c9fbf11c-7db4-40c7-a9ba-f7642385162f)

  2. "Disconnect" Button - disconnects the client from server ![DisconnectBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/01ad3b7a-8ba2-4935-9758-b4654eb131b7)
  3. "Refresh" Button - refresh the data grid with all configured nodes (can be used after opening of configuration file with Configuration button and editing of file)
     ![RefreshBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/9a4f1907-a29b-4fa3-a67b-1cd8e1e4bd04)
  4. "Configuration" Button - opens the configuration file with the client default editor (Visual Studio/Code/Nodepad++/Nodepad) ![ConfigBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/2e5de171-c754-4f96-96eb-63e972c99c4f)

  5. "Show configured nodes" radio button - Shows only the configured nodes in the configuration file ![ShowConfigNodesRadioBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/2605759f-0454-491b-93a4-fbb516d134c6)
  6. "Show selected nodes" radio button - Shows the children nodes of selected in the TreeView node ![ShowSelectedNodeChildrenRadioBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/d4fa2dbf-fd38-418a-98ad-a458af84acda)
  7. "Details" button - shows the detail page with the node value. Useful more for showing of complex node values (properties) ![detailsBtn](https://github.com/velizar92/OpcUaClient/assets/40525254/ea51a701-42a9-42f6-9d54-ea901c64bade)
  8. "Grid" control - Shows the configured nodes in the configuration file, or the children of selected node in the Tree View.
    ![Grid](https://github.com/velizar92/OpcUaClient/assets/40525254/1a31b59d-d790-497f-99de-cd832ceeca18)
  9. "TreeView" control - Shows all server nodes.
      
      ![TreeView](https://github.com/velizar92/OpcUaClient/assets/40525254/03786ab8-0df2-41a1-957f-e103d9daffa9)


     







