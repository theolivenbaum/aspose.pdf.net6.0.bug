# How to reproduce

- [Install dotnet sdk for net6.0-rc1](https://dotnet.microsoft.com/download/visual-studio-sdks)
- Call ``dotnet-run``

## What is expected to happen?
`````
Hello, World!
This pdf has 2 pages
`````

## What happens under net6.0

`````
Hello, World!
Unhandled exception. System.Exception: Exception of type 'System.Exception' was thrown.
   at #=q4IEUrftjYU$par8Q9LJ00tW0gvtn27t33MOXq5jf7M0=.#=zm2cl7e0sXMFI6CAz8GMWXa_CMUfb(Byte[] #=zk9pPDeEfDHy22YjFMAlVx0cxiTST)
   at #=q4IEUrftjYU$par8Q9LJ00tW0gvtn27t33MOXq5jf7M0=.#=zPVpv3SzZ1CG$Di_ZuxYXoFoj07C2.#=zxt3_HDWhjN$4oMngrT44m9fvCgAl(#=zs8gGwxHrwrLZ9DXJuKXjng$xZuQI #=zsbRRE7AVBvV3yHW9uMR0FY578JqX)
   at #=q4IEUrftjYU$par8Q9LJ00tW0gvtn27t33MOXq5jf7M0=.#=zTqtbr11T7uz9hvN15ZLrQ0E=(String #=z3Wip5cJegV_KU1U2UCRZzT0G7YSz)
   at #=qllKshT1pDip__5yQ1ZgMiWDnbgdvt6nJ0fuG6Etljzo=.#=zf7dkfEHN3MSp_16VNe0pi9j03P_u.#=zqIcwKZMDy3Q8$arprL6dpBZ2D5JB(String #=zA4HqL1Q6fx2uPZWw9_3LJVI=)
   at #=qllKshT1pDip__5yQ1ZgMiWDnbgdvt6nJ0fuG6Etljzo=.#=zf7dkfEHN3MSp_16VNe0pi9j03P_u.#=zAdY_up4H0SHCQ_WxCsKHAaiqiR0f()
   at #=qllKshT1pDip__5yQ1ZgMiWDnbgdvt6nJ0fuG6Etljzo=.#=zHJlfs2Em$KlgrYM_MYqEa2_WTDpn(String #=zUtwuUIQ=)
   at #=qllKshT1pDip__5yQ1ZgMiWDnbgdvt6nJ0fuG6Etljzo=.#=zeipXVKFia$bbNYxCsJFt9FUXD$7u(Object #=zOnlNdH_Up8Kjb9JvdUt$InO7FyKI, ResolveEventArgs #=zHhfzUp9CFMKt9iHTtaNZ6ysSXwSR)
   at System.Runtime.Loader.AssemblyLoadContext.InvokeResolveEvent(ResolveEventHandler eventHandler, RuntimeAssembly assembly, String name)
   at System.Runtime.Loader.AssemblyLoadContext.OnResourceResolve(RuntimeAssembly assembly, String resourceName)
   at System.Reflection.RuntimeAssembly.GetResource(QCallAssembly assembly, String resourceName, UInt32& length)
   at System.Reflection.RuntimeAssembly.GetManifestResourceStream(String name)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zxuF$jnLgINNQfljIuekeJx2UcJzXGCQgp6ZT7fL$rkwB(Object #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=z3oKjnwT0PKmWpniwq5pmOBOAq38bbeWXfFSxHck=(MethodBase #=ztP_oExU=, Boolean #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=z8xO7ggDamJCJdp_W1pIVojSMG97gOz5o5BfcaIQ=(#=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4= #=ztP_oExU=, #=q1qifqgbfO3$0lc0sUiNkrTaSFK1NEzFbCILcNw5ryyY= #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zeUIgvJDdEIsbJe6MKA==()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zxuF$jnLgINNQfljIuekeJx2UcJzXGCQgp6ZT7fL$rkwB(Object #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=z0wv4aWr_StW7lzxSbLraXQc=()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zWHkNMgef8e8BbSeDK1w928k=(#=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4= #=ztP_oExU=, #=q1qifqgbfO3$0lc0sUiNkrTaSFK1NEzFbCILcNw5ryyY= #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zeUIgvJDdEIsbJe6MKA==()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zxuF$jnLgINNQfljIuekeJx2UcJzXGCQgp6ZT7fL$rkwB(Object #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=z0wv4aWr_StW7lzxSbLraXQc=()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zeIevjL$Sx855B4bMruEAuR_ZPCBAV8OEI1OZfyM=(Object #=ztP_oExU=, UInt32 #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zNqP3E2sQff20dJ05o_iXWIThVoi2Sk_nmGhVExA=(Object[] #=ztP_oExU=, Type[] #=zAnxkIpI=, Type[] #=zmX1PT28=, Object[] #=zbYQAeF8=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zMtmAM_kxJVPx8bWzheDKWsk=(Int32 #=ztP_oExU=, Type[] #=zAnxkIpI=, Type[] #=zmX1PT28=, Boolean #=zbYQAeF8=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zPuoA45XCMdHlYrbSXg==(#=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4= #=ztP_oExU=, #=q1qifqgbfO3$0lc0sUiNkrTaSFK1NEzFbCILcNw5ryyY= #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zeUIgvJDdEIsbJe6MKA==()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zxuF$jnLgINNQfljIuekeJx2UcJzXGCQgp6ZT7fL$rkwB(Object #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=z0wv4aWr_StW7lzxSbLraXQc=()
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zeIevjL$Sx855B4bMruEAuR_ZPCBAV8OEI1OZfyM=(Object #=ztP_oExU=, UInt32 #=zAnxkIpI=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zFbEgpGbjV$l48im3Ipw7MFmbN7GbaHuddQ==(Boolean #=ztP_oExU=)
   at #=qhjhU8nqLJtFY8LRMoZFhVoeECt_CgG4DqITeBJqkpr4=.#=zNqP3E2sQff20dJ05o_iXWIThVoi2Sk_nmGhVExA=(Object[] #=ztP_oExU=, Type[] #=zAnxkIpI=, Type[] #=zmX1PT28=, Object[] #=zbYQAeF8=)
   at Aspose.Pdf.License.SetLicense(String licenseName)
   at Program.<Main>$(String[] args) in c:\dev\aspose.pdf.net60.bug\Program.cs:line 4
`````

