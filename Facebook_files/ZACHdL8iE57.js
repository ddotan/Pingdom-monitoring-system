/*!CK:3895640463!*//*1429512537,*/

if (self.CavalryLogger) { CavalryLogger.start_js(["ATD0B"]); }

__d("legacy:control-textarea",["TextAreaControl"],function(a,b,c,d){b.__markCompiled&&b.__markCompiled();a.TextAreaControl=b('TextAreaControl');},3);
__d("FBVideoChainingHide",["AsyncRequest","AttachmentRelatedShareConstants","ContextualThing","CSS","DOM","DOMQuery","Event","XPubcontentChainingHideController","csx","tidyEvent"],function(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p){b.__markCompiled&&b.__markCompiled();var q={listenForButtons:function(r,s){p(m.listen(r,'click',function(){var u=l.find(r,"^._1ui8"),v=l.find(u,"._3f-c"),w=l.find(u,"._3f-d");j.hide(v);j.show(w);}));var t=l.find(s,"._3f-e");p(m.listen(t,'click',function(){var u=l.find(s,"^._1ui8"),v=l.find(u,"._3f-c");j.hide(s);j.show(v);}));},listenForHideConfirm:function(r,s,t){p(m.listen(r,'click',function(u){setTimeout(function(){var v=i.getContext(r),w=n.getURIBuilder(),x=(v&&JSON.parse(v.getAttribute('data-ft')))||{};x.object_id=s;x.reason=t;x.chaining_type='fbvideo';new g().setMethod('POST').setURI(w.getURI()).setData(x).setRelativeTo(r).send();var y=l.find(r,"^._1ui8"),z=l.find(r,"^._4-u2");k.remove(y);var aa=l.scry(z,"._1ui8");if(aa.length===0)k.remove(z);},h.HIDE_DELAY);}));},listenForUnitHideButton:function(r,s,t){p(m.listen(r,'click',function(u){setTimeout(function(){var v=n.getURIBuilder(),w={object_id:t,unit:true,reason:0,chaining_type:'fbvideo'};new g().setMethod('POST').setURI(v.getURI()).setData(w).send();k.remove(s);},h.HIDE_DELAY);}));}};e.exports=q;},null);