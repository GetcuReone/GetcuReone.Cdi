<a name='assembly'></a>
# GetcuReone.Cdi

## Contents

- [BaseGrAdapter](#T-GetcuReone-Cdi-BaseGrAdapter 'GetcuReone.Cdi.BaseGrAdapter')
  - [AdapterName](#P-GetcuReone-Cdi-BaseGrAdapter-AdapterName 'GetcuReone.Cdi.BaseGrAdapter.AdapterName')
  - [NLogger](#P-GetcuReone-Cdi-BaseGrAdapter-NLogger 'GetcuReone.Cdi.BaseGrAdapter.NLogger')
  - [CallMethodLogging(methodName)](#M-GetcuReone-Cdi-BaseGrAdapter-CallMethodLogging-System-String- 'GetcuReone.Cdi.BaseGrAdapter.CallMethodLogging(System.String)')
  - [CallMethodLogging\`\`1(methodName,parameter)](#M-GetcuReone-Cdi-BaseGrAdapter-CallMethodLogging``1-``0,System-String- 'GetcuReone.Cdi.BaseGrAdapter.CallMethodLogging``1(``0,System.String)')
  - [ReturnLogging()](#M-GetcuReone-Cdi-BaseGrAdapter-ReturnLogging-System-String- 'GetcuReone.Cdi.BaseGrAdapter.ReturnLogging(System.String)')
  - [ReturnLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-BaseGrAdapter-ReturnLogging``1-``0,System-String- 'GetcuReone.Cdi.BaseGrAdapter.ReturnLogging``1(``0,System.String)')
  - [ReturnNotLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-BaseGrAdapter-ReturnNotLogging``1-``0,System-String- 'GetcuReone.Cdi.BaseGrAdapter.ReturnNotLogging``1(``0,System.String)')
  - [WriteLog(messageFunc)](#M-GetcuReone-Cdi-BaseGrAdapter-WriteLog-NLog-LogMessageGenerator- 'GetcuReone.Cdi.BaseGrAdapter.WriteLog(NLog.LogMessageGenerator)')
- [BaseGrFactRulesProvider](#T-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider')
  - [Factory](#P-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-Factory 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.Factory')
  - [GetAdapter\`\`1()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetAdapter``1 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetAdapter``1')
  - [GetDefaultContainer()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetDefaultContainer 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetDefaultContainer')
  - [GetDefaultFacts()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetDefaultFacts 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetDefaultFacts')
  - [GetFacade\`\`1()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetFacade``1 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetFacade``1')
  - [GetRules()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetRules 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetRules')
  - [GetSingleEntityOperations()](#M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetSingleEntityOperations 'GetcuReone.Cdi.FactFactory.BaseGrFactRulesProvider.GetSingleEntityOperations')
- [CdiHelper](#T-GetcuReone-Cdi-CdiHelper 'GetcuReone.Cdi.CdiHelper')
  - [CreateException(code,reason)](#M-GetcuReone-Cdi-CdiHelper-CreateException-System-String,System-String- 'GetcuReone.Cdi.CdiHelper.CreateException(System.String,System.String)')
  - [CreateException(details)](#M-GetcuReone-Cdi-CdiHelper-CreateException-System-Collections-Generic-List{GetcuReone-Cdm-Errors-ErrorDetail}- 'GetcuReone.Cdi.CdiHelper.CreateException(System.Collections.Generic.List{GetcuReone.Cdm.Errors.ErrorDetail})')
  - [CreateFactFactory\`\`1(factory)](#M-GetcuReone-Cdi-CdiHelper-CreateFactFactory``1-GetcuReone-ComboPatterns-Interfaces-IAbstractFactory- 'GetcuReone.Cdi.CdiHelper.CreateFactFactory``1(GetcuReone.ComboPatterns.Interfaces.IAbstractFactory)')
  - [ToReadOnlyCollection\`\`1(list)](#M-GetcuReone-Cdi-CdiHelper-ToReadOnlyCollection``1-System-Collections-Generic-IList{``0}- 'GetcuReone.Cdi.CdiHelper.ToReadOnlyCollection``1(System.Collections.Generic.IList{``0})')
- [EnumerableExtensions](#T-GetcuReone-Cdi-Extensions-EnumerableExtensions 'GetcuReone.Cdi.Extensions.EnumerableExtensions')
  - [IsNullOrEmpty\`\`1(items)](#M-GetcuReone-Cdi-Extensions-EnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}- 'GetcuReone.Cdi.Extensions.EnumerableExtensions.IsNullOrEmpty``1(System.Collections.Generic.IEnumerable{``0})')
- [FactContainerExtensions](#T-GetcuReone-Cdi-Extensions-FactContainerExtensions 'GetcuReone.Cdi.Extensions.FactContainerExtensions')
  - [UpdateFact\`\`2(container,fact)](#M-GetcuReone-Cdi-Extensions-FactContainerExtensions-UpdateFact``2-``0,``1- 'GetcuReone.Cdi.Extensions.FactContainerExtensions.UpdateFact``2(``0,``1)')
- [GrAdapterProxyBase\`1](#T-GetcuReone-Cdi-GrAdapterProxyBase`1 'GetcuReone.Cdi.GrAdapterProxyBase`1')
  - [#ctor(createProxyFunc)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-#ctor-System-Func{`0}- 'GetcuReone.Cdi.GrAdapterProxyBase`1.#ctor(System.Func{`0})')
  - [AdapterName](#P-GetcuReone-Cdi-GrAdapterProxyBase`1-AdapterName 'GetcuReone.Cdi.GrAdapterProxyBase`1.AdapterName')
  - [NLogger](#P-GetcuReone-Cdi-GrAdapterProxyBase`1-NLogger 'GetcuReone.Cdi.GrAdapterProxyBase`1.NLogger')
  - [CallMethodLogging(methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-CallMethodLogging-System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`1.CallMethodLogging(System.String)')
  - [CallMethodLogging\`\`1(methodName,parameter)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-CallMethodLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`1.CallMethodLogging``1(``0,System.String)')
  - [ReturnLogging()](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnLogging-System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`1.ReturnLogging(System.String)')
  - [ReturnLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`1.ReturnLogging``1(``0,System.String)')
  - [ReturnNotLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnNotLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`1.ReturnNotLogging``1(``0,System.String)')
  - [WriteLog(messageFunc)](#M-GetcuReone-Cdi-GrAdapterProxyBase`1-WriteLog-NLog-LogMessageGenerator- 'GetcuReone.Cdi.GrAdapterProxyBase`1.WriteLog(NLog.LogMessageGenerator)')
- [GrAdapterProxyBase\`2](#T-GetcuReone-Cdi-GrAdapterProxyBase`2 'GetcuReone.Cdi.GrAdapterProxyBase`2')
  - [#ctor(createProxyFunc)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-#ctor-System-Func{`1,`0}- 'GetcuReone.Cdi.GrAdapterProxyBase`2.#ctor(System.Func{`1,`0})')
  - [AdapterName](#P-GetcuReone-Cdi-GrAdapterProxyBase`2-AdapterName 'GetcuReone.Cdi.GrAdapterProxyBase`2.AdapterName')
  - [NLogger](#P-GetcuReone-Cdi-GrAdapterProxyBase`2-NLogger 'GetcuReone.Cdi.GrAdapterProxyBase`2.NLogger')
  - [CallMethodLogging(methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-CallMethodLogging-System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`2.CallMethodLogging(System.String)')
  - [CallMethodLogging\`\`1(methodName,parameter)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-CallMethodLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`2.CallMethodLogging``1(``0,System.String)')
  - [ReturnLogging()](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnLogging-System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`2.ReturnLogging(System.String)')
  - [ReturnLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`2.ReturnLogging``1(``0,System.String)')
  - [ReturnNotLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnNotLogging``1-``0,System-String- 'GetcuReone.Cdi.GrAdapterProxyBase`2.ReturnNotLogging``1(``0,System.String)')
  - [WriteLog(messageFunc)](#M-GetcuReone-Cdi-GrAdapterProxyBase`2-WriteLog-NLog-LogMessageGenerator- 'GetcuReone.Cdi.GrAdapterProxyBase`2.WriteLog(NLog.LogMessageGenerator)')
- [GrFacadeBase](#T-GetcuReone-Cdi-GrFacadeBase 'GetcuReone.Cdi.GrFacadeBase')
  - [FacadeName](#P-GetcuReone-Cdi-GrFacadeBase-FacadeName 'GetcuReone.Cdi.GrFacadeBase.FacadeName')
  - [NLogger](#P-GetcuReone-Cdi-GrFacadeBase-NLogger 'GetcuReone.Cdi.GrFacadeBase.NLogger')
  - [CallMethodLogging(methodName)](#M-GetcuReone-Cdi-GrFacadeBase-CallMethodLogging-System-String- 'GetcuReone.Cdi.GrFacadeBase.CallMethodLogging(System.String)')
  - [CallMethodLogging\`\`1(methodName,parameter)](#M-GetcuReone-Cdi-GrFacadeBase-CallMethodLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFacadeBase.CallMethodLogging``1(``0,System.String)')
  - [GetAdapter\`\`1()](#M-GetcuReone-Cdi-GrFacadeBase-GetAdapter``1 'GetcuReone.Cdi.GrFacadeBase.GetAdapter``1')
  - [ReturnLogging()](#M-GetcuReone-Cdi-GrFacadeBase-ReturnLogging-System-String- 'GetcuReone.Cdi.GrFacadeBase.ReturnLogging(System.String)')
  - [ReturnLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrFacadeBase-ReturnLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFacadeBase.ReturnLogging``1(``0,System.String)')
  - [ReturnNotLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrFacadeBase-ReturnNotLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFacadeBase.ReturnNotLogging``1(``0,System.String)')
  - [WriteLog(messageFunc)](#M-GetcuReone-Cdi-GrFacadeBase-WriteLog-NLog-LogMessageGenerator- 'GetcuReone.Cdi.GrFacadeBase.WriteLog(NLog.LogMessageGenerator)')
- [GrFactFactory](#T-GetcuReone-Cdi-FactFactory-GrFactFactory 'GetcuReone.Cdi.FactFactory.GrFactFactory')
  - [#ctor(provider)](#M-GetcuReone-Cdi-FactFactory-GrFactFactory-#ctor-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider- 'GetcuReone.Cdi.FactFactory.GrFactFactory.#ctor(GetcuReone.Cdi.FactFactory.IGrFactRulesProvider)')
  - [Provider](#P-GetcuReone-Cdi-FactFactory-GrFactFactory-Provider 'GetcuReone.Cdi.FactFactory.GrFactFactory.Provider')
  - [Rules](#P-GetcuReone-Cdi-FactFactory-GrFactFactory-Rules 'GetcuReone.Cdi.FactFactory.GrFactFactory.Rules')
  - [GetDefaultContainer()](#M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetDefaultContainer 'GetcuReone.Cdi.FactFactory.GrFactFactory.GetDefaultContainer')
  - [GetDefaultFacts()](#M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetDefaultFacts-GetcuReone-FactFactory-Interfaces-Context-IWantActionContext- 'GetcuReone.Cdi.FactFactory.GrFactFactory.GetDefaultFacts(GetcuReone.FactFactory.Interfaces.Context.IWantActionContext)')
  - [GetSingleEntityOperations()](#M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetSingleEntityOperations 'GetcuReone.Cdi.FactFactory.GrFactFactory.GetSingleEntityOperations')
- [GrFactoryBase](#T-GetcuReone-Cdi-GrFactoryBase 'GetcuReone.Cdi.GrFactoryBase')
  - [FactoryName](#P-GetcuReone-Cdi-GrFactoryBase-FactoryName 'GetcuReone.Cdi.GrFactoryBase.FactoryName')
  - [NLogger](#P-GetcuReone-Cdi-GrFactoryBase-NLogger 'GetcuReone.Cdi.GrFactoryBase.NLogger')
  - [CallMethodLogging(methodName)](#M-GetcuReone-Cdi-GrFactoryBase-CallMethodLogging-System-String- 'GetcuReone.Cdi.GrFactoryBase.CallMethodLogging(System.String)')
  - [CallMethodLogging\`\`1(methodName,parameter)](#M-GetcuReone-Cdi-GrFactoryBase-CallMethodLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFactoryBase.CallMethodLogging``1(``0,System.String)')
  - [GetAdapter\`\`1()](#M-GetcuReone-Cdi-GrFactoryBase-GetAdapter``1 'GetcuReone.Cdi.GrFactoryBase.GetAdapter``1')
  - [GetFacade\`\`1()](#M-GetcuReone-Cdi-GrFactoryBase-GetFacade``1 'GetcuReone.Cdi.GrFactoryBase.GetFacade``1')
  - [GetFactFactory\`\`1(needNewFactory)](#M-GetcuReone-Cdi-GrFactoryBase-GetFactFactory``1-System-Boolean- 'GetcuReone.Cdi.GrFactoryBase.GetFactFactory``1(System.Boolean)')
  - [ReturnLogging()](#M-GetcuReone-Cdi-GrFactoryBase-ReturnLogging-System-String- 'GetcuReone.Cdi.GrFactoryBase.ReturnLogging(System.String)')
  - [ReturnLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrFactoryBase-ReturnLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFactoryBase.ReturnLogging``1(``0,System.String)')
  - [ReturnNotLogging\`\`1(returnedObj,methodName)](#M-GetcuReone-Cdi-GrFactoryBase-ReturnNotLogging``1-``0,System-String- 'GetcuReone.Cdi.GrFactoryBase.ReturnNotLogging``1(``0,System.String)')
  - [WriteLog(messageFunc)](#M-GetcuReone-Cdi-GrFactoryBase-WriteLog-NLog-LogMessageGenerator- 'GetcuReone.Cdi.GrFactoryBase.WriteLog(NLog.LogMessageGenerator)')
- [IGrFactFactory](#T-GetcuReone-Cdi-FactFactory-IGrFactFactory 'GetcuReone.Cdi.FactFactory.IGrFactFactory')
  - [Provider](#P-GetcuReone-Cdi-FactFactory-IGrFactFactory-Provider 'GetcuReone.Cdi.FactFactory.IGrFactFactory.Provider')
- [IGrFactRulesProvider](#T-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider')
  - [GetDefaultContainer()](#M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetDefaultContainer 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider.GetDefaultContainer')
  - [GetDefaultFacts()](#M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetDefaultFacts 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider.GetDefaultFacts')
  - [GetRules()](#M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetRules 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider.GetRules')
  - [GetSingleEntityOperations()](#M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetSingleEntityOperations 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider.GetSingleEntityOperations')
- [ListExtensions](#T-GetcuReone-Cdi-Extensions-ListExtensions 'GetcuReone.Cdi.Extensions.ListExtensions')
  - [MayBeNull\`\`1(items)](#M-GetcuReone-Cdi-Extensions-ListExtensions-MayBeNull``1-System-Collections-Generic-List{``0}- 'GetcuReone.Cdi.Extensions.ListExtensions.MayBeNull``1(System.Collections.Generic.List{``0})')
  - [ToReadOnlyCollection\`\`1(list)](#M-GetcuReone-Cdi-Extensions-ListExtensions-ToReadOnlyCollection``1-System-Collections-Generic-IList{``0}- 'GetcuReone.Cdi.Extensions.ListExtensions.ToReadOnlyCollection``1(System.Collections.Generic.IList{``0})')
- [StringExtensions](#T-GetcuReone-Cdi-Extensions-StringExtensions 'GetcuReone.Cdi.Extensions.StringExtensions')
  - [EqualsOrdinal(first,second)](#M-GetcuReone-Cdi-Extensions-StringExtensions-EqualsOrdinal-System-String,System-String- 'GetcuReone.Cdi.Extensions.StringExtensions.EqualsOrdinal(System.String,System.String)')
  - [EqualsOrdinalIgnoreCase(first,second)](#M-GetcuReone-Cdi-Extensions-StringExtensions-EqualsOrdinalIgnoreCase-System-String,System-String- 'GetcuReone.Cdi.Extensions.StringExtensions.EqualsOrdinalIgnoreCase(System.String,System.String)')

<a name='T-GetcuReone-Cdi-BaseGrAdapter'></a>
## BaseGrAdapter `type`

##### Namespace

GetcuReone.Cdi

##### Summary

Base class for adapters.

<a name='P-GetcuReone-Cdi-BaseGrAdapter-AdapterName'></a>
### AdapterName `property`

##### Summary

Adapter name.

<a name='P-GetcuReone-Cdi-BaseGrAdapter-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='M-GetcuReone-Cdi-BaseGrAdapter-CallMethodLogging-System-String-'></a>
### CallMethodLogging(methodName) `method`

##### Summary

Logs a method call without parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-BaseGrAdapter-CallMethodLogging``1-``0,System-String-'></a>
### CallMethodLogging\`\`1(methodName,parameter) `method`

##### Summary

Logs a method call with parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [\`\`0](#T-``0 '``0') |  |
| parameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TParameter |  |

<a name='M-GetcuReone-Cdi-BaseGrAdapter-ReturnLogging-System-String-'></a>
### ReturnLogging() `method`

##### Summary

Logs no response.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-BaseGrAdapter-ReturnLogging``1-``0,System-String-'></a>
### ReturnLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Logs the result of a method.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-BaseGrAdapter-ReturnNotLogging``1-``0,System-String-'></a>
### ReturnNotLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Add information to the log that the object is not logged.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-BaseGrAdapter-WriteLog-NLog-LogMessageGenerator-'></a>
### WriteLog(messageFunc) `method`

##### Summary

Write log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageFunc | [NLog.LogMessageGenerator](#T-NLog-LogMessageGenerator 'NLog.LogMessageGenerator') |  |

<a name='T-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider'></a>
## BaseGrFactRulesProvider `type`

##### Namespace

GetcuReone.Cdi.FactFactory

##### Summary

Base class for provider.

<a name='P-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-Factory'></a>
### Factory `property`

##### Summary

Factory.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetAdapter``1'></a>
### GetAdapter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetDefaultContainer'></a>
### GetDefaultContainer() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetDefaultFacts'></a>
### GetDefaultFacts() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetFacade``1'></a>
### GetFacade\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetRules'></a>
### GetRules() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-BaseGrFactRulesProvider-GetSingleEntityOperations'></a>
### GetSingleEntityOperations() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-CdiHelper'></a>
## CdiHelper `type`

##### Namespace

GetcuReone.Cdi

##### Summary

Common domain infrastructure helper.

<a name='M-GetcuReone-Cdi-CdiHelper-CreateException-System-String,System-String-'></a>
### CreateException(code,reason) `method`

##### Summary

Create exception.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | error code. |
| reason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | error reason. |

<a name='M-GetcuReone-Cdi-CdiHelper-CreateException-System-Collections-Generic-List{GetcuReone-Cdm-Errors-ErrorDetail}-'></a>
### CreateException(details) `method`

##### Summary

Create exception.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| details | [System.Collections.Generic.List{GetcuReone.Cdm.Errors.ErrorDetail}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{GetcuReone.Cdm.Errors.ErrorDetail}') |  |

<a name='M-GetcuReone-Cdi-CdiHelper-CreateFactFactory``1-GetcuReone-ComboPatterns-Interfaces-IAbstractFactory-'></a>
### CreateFactFactory\`\`1(factory) `method`

##### Summary

Create fact factory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| factory | [GetcuReone.ComboPatterns.Interfaces.IAbstractFactory](#T-GetcuReone-ComboPatterns-Interfaces-IAbstractFactory 'GetcuReone.ComboPatterns.Interfaces.IAbstractFactory') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TProvider |  |

<a name='M-GetcuReone-Cdi-CdiHelper-ToReadOnlyCollection``1-System-Collections-Generic-IList{``0}-'></a>
### ToReadOnlyCollection\`\`1(list) `method`

##### Summary

To [ReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyCollection`1 'System.Collections.ObjectModel.ReadOnlyCollection`1')

##### Returns

Read-only collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TItem |  |

<a name='T-GetcuReone-Cdi-Extensions-EnumerableExtensions'></a>
## EnumerableExtensions `type`

##### Namespace

GetcuReone.Cdi.Extensions

##### Summary

Extensions methods for [IEnumerable\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1')

<a name='M-GetcuReone-Cdi-Extensions-EnumerableExtensions-IsNullOrEmpty``1-System-Collections-Generic-IEnumerable{``0}-'></a>
### IsNullOrEmpty\`\`1(items) `method`

##### Summary

Is null or empty.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.IEnumerable{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TItem |  |

<a name='T-GetcuReone-Cdi-Extensions-FactContainerExtensions'></a>
## FactContainerExtensions `type`

##### Namespace

GetcuReone.Cdi.Extensions

##### Summary

Extensions methods for [IFactContainer](#T-GetcuReone-FactFactory-Interfaces-IFactContainer 'GetcuReone.FactFactory.Interfaces.IFactContainer')

<a name='M-GetcuReone-Cdi-Extensions-FactContainerExtensions-UpdateFact``2-``0,``1-'></a>
### UpdateFact\`\`2(container,fact) `method`

##### Summary

Update or add fact.

##### Returns

`container`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| container | [\`\`0](#T-``0 '``0') |  |
| fact | [\`\`1](#T-``1 '``1') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFact |  |
| TFactContainer |  |

<a name='T-GetcuReone-Cdi-GrAdapterProxyBase`1'></a>
## GrAdapterProxyBase\`1 `type`

##### Namespace

GetcuReone.Cdi

##### Summary

Base class for adapters.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-#ctor-System-Func{`0}-'></a>
### #ctor(createProxyFunc) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| createProxyFunc | [System.Func{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`0}') |  |

<a name='P-GetcuReone-Cdi-GrAdapterProxyBase`1-AdapterName'></a>
### AdapterName `property`

##### Summary

Adapter name.

<a name='P-GetcuReone-Cdi-GrAdapterProxyBase`1-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-CallMethodLogging-System-String-'></a>
### CallMethodLogging(methodName) `method`

##### Summary

Logs a method call without parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-CallMethodLogging``1-``0,System-String-'></a>
### CallMethodLogging\`\`1(methodName,parameter) `method`

##### Summary

Logs a method call with parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [\`\`0](#T-``0 '``0') |  |
| parameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TParameter |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnLogging-System-String-'></a>
### ReturnLogging() `method`

##### Summary

Logs no response.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnLogging``1-``0,System-String-'></a>
### ReturnLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Logs the result of a method.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-ReturnNotLogging``1-``0,System-String-'></a>
### ReturnNotLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Add information to the log that the object is not logged.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`1-WriteLog-NLog-LogMessageGenerator-'></a>
### WriteLog(messageFunc) `method`

##### Summary

Write log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageFunc | [NLog.LogMessageGenerator](#T-NLog-LogMessageGenerator 'NLog.LogMessageGenerator') |  |

<a name='T-GetcuReone-Cdi-GrAdapterProxyBase`2'></a>
## GrAdapterProxyBase\`2 `type`

##### Namespace

GetcuReone.Cdi

##### Summary

Base class for adapters.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-#ctor-System-Func{`1,`0}-'></a>
### #ctor(createProxyFunc) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| createProxyFunc | [System.Func{\`1,\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{`1,`0}') |  |

<a name='P-GetcuReone-Cdi-GrAdapterProxyBase`2-AdapterName'></a>
### AdapterName `property`

##### Summary

Adapter name.

<a name='P-GetcuReone-Cdi-GrAdapterProxyBase`2-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-CallMethodLogging-System-String-'></a>
### CallMethodLogging(methodName) `method`

##### Summary

Logs a method call without parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-CallMethodLogging``1-``0,System-String-'></a>
### CallMethodLogging\`\`1(methodName,parameter) `method`

##### Summary

Logs a method call with parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [\`\`0](#T-``0 '``0') |  |
| parameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TParameter |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnLogging-System-String-'></a>
### ReturnLogging() `method`

##### Summary

Logs no response.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnLogging``1-``0,System-String-'></a>
### ReturnLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Logs the result of a method.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-ReturnNotLogging``1-``0,System-String-'></a>
### ReturnNotLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Add information to the log that the object is not logged.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrAdapterProxyBase`2-WriteLog-NLog-LogMessageGenerator-'></a>
### WriteLog(messageFunc) `method`

##### Summary

Write log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageFunc | [NLog.LogMessageGenerator](#T-NLog-LogMessageGenerator 'NLog.LogMessageGenerator') |  |

<a name='T-GetcuReone-Cdi-GrFacadeBase'></a>
## GrFacadeBase `type`

##### Namespace

GetcuReone.Cdi

##### Summary

Base clas for facades.

<a name='P-GetcuReone-Cdi-GrFacadeBase-FacadeName'></a>
### FacadeName `property`

##### Summary

Facade name.

<a name='P-GetcuReone-Cdi-GrFacadeBase-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='M-GetcuReone-Cdi-GrFacadeBase-CallMethodLogging-System-String-'></a>
### CallMethodLogging(methodName) `method`

##### Summary

Logs a method call without parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-GrFacadeBase-CallMethodLogging``1-``0,System-String-'></a>
### CallMethodLogging\`\`1(methodName,parameter) `method`

##### Summary

Logs a method call with parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [\`\`0](#T-``0 '``0') |  |
| parameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TParameter |  |

<a name='M-GetcuReone-Cdi-GrFacadeBase-GetAdapter``1'></a>
### GetAdapter\`\`1() `method`

##### Summary

Get adapter.

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TAdapter |  |

<a name='M-GetcuReone-Cdi-GrFacadeBase-ReturnLogging-System-String-'></a>
### ReturnLogging() `method`

##### Summary

Logs no response.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrFacadeBase-ReturnLogging``1-``0,System-String-'></a>
### ReturnLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Logs the result of a method.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrFacadeBase-ReturnNotLogging``1-``0,System-String-'></a>
### ReturnNotLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Add information to the log that the object is not logged.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrFacadeBase-WriteLog-NLog-LogMessageGenerator-'></a>
### WriteLog(messageFunc) `method`

##### Summary

Write log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageFunc | [NLog.LogMessageGenerator](#T-NLog-LogMessageGenerator 'NLog.LogMessageGenerator') |  |

<a name='T-GetcuReone-Cdi-FactFactory-GrFactFactory'></a>
## GrFactFactory `type`

##### Namespace

GetcuReone.Cdi.FactFactory

##### Summary

Fact factory.

<a name='M-GetcuReone-Cdi-FactFactory-GrFactFactory-#ctor-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-'></a>
### #ctor(provider) `constructor`

##### Summary

Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| provider | [GetcuReone.Cdi.FactFactory.IGrFactRulesProvider](#T-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider 'GetcuReone.Cdi.FactFactory.IGrFactRulesProvider') |  |

<a name='P-GetcuReone-Cdi-FactFactory-GrFactFactory-Provider'></a>
### Provider `property`

##### Summary

*Inherit from parent.*

<a name='P-GetcuReone-Cdi-FactFactory-GrFactFactory-Rules'></a>
### Rules `property`

##### Summary

Rule collection.

<a name='M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetDefaultContainer'></a>
### GetDefaultContainer() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetDefaultFacts-GetcuReone-FactFactory-Interfaces-Context-IWantActionContext-'></a>
### GetDefaultFacts() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-GrFactFactory-GetSingleEntityOperations'></a>
### GetSingleEntityOperations() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-GrFactoryBase'></a>
## GrFactoryBase `type`

##### Namespace

GetcuReone.Cdi

##### Summary

*Inherit from parent.*

##### Remarks

Added logging.

<a name='P-GetcuReone-Cdi-GrFactoryBase-FactoryName'></a>
### FactoryName `property`

##### Summary

Factory name.

<a name='P-GetcuReone-Cdi-GrFactoryBase-NLogger'></a>
### NLogger `property`

##### Summary

Logger.

<a name='M-GetcuReone-Cdi-GrFactoryBase-CallMethodLogging-System-String-'></a>
### CallMethodLogging(methodName) `method`

##### Summary

Logs a method call without parameters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-GrFactoryBase-CallMethodLogging``1-``0,System-String-'></a>
### CallMethodLogging\`\`1(methodName,parameter) `method`

##### Summary

Logs a method call with parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| methodName | [\`\`0](#T-``0 '``0') |  |
| parameter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TParameter |  |

<a name='M-GetcuReone-Cdi-GrFactoryBase-GetAdapter``1'></a>
### GetAdapter\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrFactoryBase-GetFacade``1'></a>
### GetFacade\`\`1() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrFactoryBase-GetFactFactory``1-System-Boolean-'></a>
### GetFactFactory\`\`1(needNewFactory) `method`

##### Summary

Get fact factory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| needNewFactory | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TFactRulesProvider |  |

<a name='M-GetcuReone-Cdi-GrFactoryBase-ReturnLogging-System-String-'></a>
### ReturnLogging() `method`

##### Summary

Logs no response.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-GrFactoryBase-ReturnLogging``1-``0,System-String-'></a>
### ReturnLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Logs the result of a method.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrFactoryBase-ReturnNotLogging``1-``0,System-String-'></a>
### ReturnNotLogging\`\`1(returnedObj,methodName) `method`

##### Summary

Add information to the log that the object is not logged.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| returnedObj | [\`\`0](#T-``0 '``0') |  |
| methodName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TResult |  |

<a name='M-GetcuReone-Cdi-GrFactoryBase-WriteLog-NLog-LogMessageGenerator-'></a>
### WriteLog(messageFunc) `method`

##### Summary

Write log.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageFunc | [NLog.LogMessageGenerator](#T-NLog-LogMessageGenerator 'NLog.LogMessageGenerator') |  |

<a name='T-GetcuReone-Cdi-FactFactory-IGrFactFactory'></a>
## IGrFactFactory `type`

##### Namespace

GetcuReone.Cdi.FactFactory

##### Summary

Fact Factory with Data Provider.

<a name='P-GetcuReone-Cdi-FactFactory-IGrFactFactory-Provider'></a>
### Provider `property`

##### Summary

*Inherit from parent.*

<a name='T-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider'></a>
## IGrFactRulesProvider `type`

##### Namespace

GetcuReone.Cdi.FactFactory

##### Summary

Fact factory data provider

<a name='M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetDefaultContainer'></a>
### GetDefaultContainer() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetDefaultFacts'></a>
### GetDefaultFacts() `method`

##### Summary

Get default facts.

##### Returns

default facts.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetRules'></a>
### GetRules() `method`

##### Summary

Get fact rules.

##### Returns

Fact rules.

##### Parameters

This method has no parameters.

<a name='M-GetcuReone-Cdi-FactFactory-IGrFactRulesProvider-GetSingleEntityOperations'></a>
### GetSingleEntityOperations() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-GetcuReone-Cdi-Extensions-ListExtensions'></a>
## ListExtensions `type`

##### Namespace

GetcuReone.Cdi.Extensions

##### Summary

Extensions methods for [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

<a name='M-GetcuReone-Cdi-Extensions-ListExtensions-MayBeNull``1-System-Collections-Generic-List{``0}-'></a>
### MayBeNull\`\`1(items) `method`

##### Summary

If the `items` is null it will create a new empty list.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| items | [System.Collections.Generic.List{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TItem |  |

<a name='M-GetcuReone-Cdi-Extensions-ListExtensions-ToReadOnlyCollection``1-System-Collections-Generic-IList{``0}-'></a>
### ToReadOnlyCollection\`\`1(list) `method`

##### Summary

To [ReadOnlyCollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.ObjectModel.ReadOnlyCollection`1 'System.Collections.ObjectModel.ReadOnlyCollection`1')

##### Returns

Read-only collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TItem |  |

<a name='T-GetcuReone-Cdi-Extensions-StringExtensions'></a>
## StringExtensions `type`

##### Namespace

GetcuReone.Cdi.Extensions

##### Summary

Extensions methods [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

<a name='M-GetcuReone-Cdi-Extensions-StringExtensions-EqualsOrdinal-System-String,System-String-'></a>
### EqualsOrdinal(first,second) `method`

##### Summary

[Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Equals 'System.String.Equals(System.String)') with [Ordinal](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison.Ordinal 'System.StringComparison.Ordinal').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| second | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-GetcuReone-Cdi-Extensions-StringExtensions-EqualsOrdinalIgnoreCase-System-String,System-String-'></a>
### EqualsOrdinalIgnoreCase(first,second) `method`

##### Summary

[Equals](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String.Equals 'System.String.Equals(System.String)') with [OrdinalIgnoreCase](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.StringComparison.OrdinalIgnoreCase 'System.StringComparison.OrdinalIgnoreCase').

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| second | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
