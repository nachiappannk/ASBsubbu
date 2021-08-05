# ASBsubbu

```
func init LocalFunctionProj --worker-runtime dotnetisolated
cd LocalFunctionProj
func new 
```

choose servicebusqueuetrigger
and then enter the function name 

now the code is generated, include "connectionString" as one of the key in local.settings.json and for value, get from Azure website
and in <functionname.cs>, change the queue name to the ASB queue that functions listens to. 
