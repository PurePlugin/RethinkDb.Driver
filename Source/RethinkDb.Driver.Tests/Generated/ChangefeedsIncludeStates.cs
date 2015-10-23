




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
    public class ChangefeedsIncludeStates : GeneratedTest {

        public ChangefeedsIncludeStates (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #4
                 /* ExpectedOriginal: [{'state':'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "ready"));
                 
                 /* Original: tbl.changes(squash=true, include_states=true).limit(1) */
                 var obtained = runOrCatch( tbl.changes().optArg("squash", true).optArg("include_states", true).limit(1L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #9
                 /* ExpectedOriginal: [{'state':'initializing'}, {'new_val':null}, {'state':'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", null), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.get(0).changes(squash=true, include_states=true, include_initial=true).limit(3) */
                 var obtained = runOrCatch( tbl.get(0L).changes().optArg("squash", true).optArg("include_states", true).optArg("include_initial", true).limit(3L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #14
                 /* ExpectedOriginal: [{'state':'initializing'}, {'state':'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true, include_initial=true).limit(2) */
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("squash", true).optArg("include_states", true).optArg("include_initial", true).limit(2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #19
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: tbl.insert({'id':1}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 1L)) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #21
                 /* ExpectedOriginal: [{'state':'initializing'}, {'new_val':{'id':1}}, {'state':'ready'}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("state", "ready"));
                 
                 /* Original: tbl.order_by(index='id').limit(10).changes(squash=true, include_states=true, include_initial=true).limit(3) */
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("squash", true).optArg("include_states", true).optArg("include_initial", true).limit(3L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #26
             //Original: tblchanges = tbl.changes(squash=true, include_states=true)
             
                 var tblchanges = maybeRun( (Changes) (tbl.changes().optArg("squash", true).optArg("include_states", true)) , conn);
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #30
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: tbl.insert({'id':2}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L)) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #32
                 /* ExpectedOriginal: [{'state':'ready'},{'new_val':{'id':2},'old_val':null}] */
                 var expected_ = r.array(r.hashMap("state", "ready"), r.hashMap("new_val", r.hashMap("id", 2L)).with("old_val", null));
                 
                 /* Original: fetch(tblchanges, 2) */
                 var obtained = runOrCatch( fetch(tblchanges, 2L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #35
             //Original: getchanges = tbl.get(2).changes(include_states=true, include_initial=true)
             
                 var getchanges = maybeRun( (Changes) (tbl.get(2L).changes().optArg("include_states", true).optArg("include_initial", true)) , conn);
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #39
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: tbl.get(2).update({'a':1}) */
                 var obtained = runOrCatch( tbl.get(2L).update(r.hashMap("a", 1L)) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #41
                 /* ExpectedOriginal: [{'state':'initializing'}, {'new_val':{'id':2}}, {'state':'ready'}, {'old_val':{'id':2},'new_val':{'id':2,'a':1}}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 2L)), r.hashMap("state", "ready"), r.hashMap("old_val", r.hashMap("id", 2L)).with("new_val", r.hashMap("id", 2L).with("a", 1L)));
                 
                 /* Original: fetch(getchanges, 4) */
                 var obtained = runOrCatch( fetch(getchanges, 4L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, changefeeds/include_states.yaml, #44
             //Original: limitchanges = tbl.order_by(index='id').limit(10).changes(include_states=true, include_initial=true)
             
                 var limitchanges = maybeRun( (Changes) (tbl.orderBy().optArg("index", "id").limit(10L).changes().optArg("include_states", true).optArg("include_initial", true)) , conn);
             
             
             //JavaDef, changefeeds/include_states.yaml, #48
             //Original: limitchangesdesc = tbl.order_by(index=r.desc('id')).limit(10).changes(include_states=true, include_initial=true)
             
                 var limitchangesdesc = maybeRun( (Changes) (tbl.orderBy().optArg("index", r.desc("id")).limit(10L).changes().optArg("include_states", true).optArg("include_initial", true)) , conn);
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #52
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: tbl.insert({'id':3}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L)) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #54
                 /* ExpectedOriginal: [{'state':'initializing'}, {'new_val':{'id':1}}, {'new_val':{'a':1, 'id':2}}, {'state':'ready'}, {'old_val':null, 'new_val':{'id':3}}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("new_val", r.hashMap("a", 1L).with("id", 2L)), r.hashMap("state", "ready"), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 3L)));
                 
                 /* Original: fetch(limitchanges, 5) */
                 var obtained = runOrCatch( fetch(limitchanges, 5L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, changefeeds/include_states.yaml, #57
                 /* ExpectedOriginal: [{'state':'initializing'}, {'new_val':{'a':1, 'id':2}}, {'new_val':{'id':1}}, {'state':'ready'}, {'old_val':null, 'new_val':{'id':3}}] */
                 var expected_ = r.array(r.hashMap("state", "initializing"), r.hashMap("new_val", r.hashMap("a", 1L).with("id", 2L)), r.hashMap("new_val", r.hashMap("id", 1L)), r.hashMap("state", "ready"), r.hashMap("old_val", null).with("new_val", r.hashMap("id", 3L)));
                 
                 /* Original: fetch(limitchangesdesc, 5) */
                 var obtained = runOrCatch( fetch(limitchangesdesc, 5L) ,
                                            new OptArgs()
                    , conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
