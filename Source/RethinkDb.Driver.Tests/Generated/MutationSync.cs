




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class MutationSync : GeneratedTest {

        public MutationSync (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #5
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test1') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test1") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #7
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test1soft') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test1soft") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #9
                 /* ExpectedOriginal: {'skipped':0, 'deleted':0, 'unchanged':0, 'errors':0, 'replaced':1, 'inserted':0} */
                 var expected_ = r.hashMap("skipped", 0L).with("deleted", 0L).with("unchanged", 0L).with("errors", 0L).with("replaced", 1L).with("inserted", 0L);
                 
                 /* Original: r.db('test').table('test1soft').config().update({'durability':'soft'}) */
                 var obtained = runOrCatch( r.db("test").table("test1soft").config().update(r.hashMap("durability", "soft")) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, mutation/sync.yaml, #11
             //Original: tbl = r.db('test').table('test1')
             
                 var tbl = (Table) (r.db("test").table("test1"));
             
             
             //JavaDef, mutation/sync.yaml, #12
             //Original: tbl_soft = r.db('test').table('test1soft')
             
                 var tbl_soft = (Table) (r.db("test").table("test1soft"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #13
                 /* ExpectedOriginal: partial({'created':1}) */
                 var expected_ = partial(r.hashMap("created", 1L));
                 
                 /* Original: tbl.index_create('x') */
                 var obtained = runOrCatch( tbl.indexCreate("x") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #15
                 /* ExpectedOriginal: [{'ready':True, 'index':'x'}] */
                 var expected_ = r.array(r.hashMap("ready", true).with("index", "x"));
                 
                 /* Original: tbl.index_wait('x').pluck('index', 'ready') */
                 var obtained = runOrCatch( tbl.indexWait("x").pluck("index", "ready") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #19
                 /* ExpectedOriginal: {'synced':1} */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #21
                 /* ExpectedOriginal: {'synced':1} */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl_soft.sync() */
                 var obtained = runOrCatch( tbl_soft.sync() ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #23
                 /* ExpectedOriginal: {'synced':1} */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                     .with("durability", "soft")
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #27
                 /* ExpectedOriginal: {'synced':1} */
                 var expected_ = r.hashMap("synced", 1L);
                 
                 /* Original: tbl.sync() */
                 var obtained = runOrCatch( tbl.sync() ,
                                            new OptArgs()
                     .with("durability", "hard")
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #48
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test1') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test1") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/sync.yaml, #50
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test1soft') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test1soft") ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
