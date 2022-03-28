% Create all the points along a spline curve
%    Control points "inp", "n" of them.
%    Knots "knots", degree "t".
%    Ouput curve "outp", "res" of them.    
function [outp, res] = SplineCurve(control, n, knots, t, outp, res)   
interval=0;
increment = (n-t+2)/(res-1);
for i=1:1:res-1
    temp=SplinePoints(knots, n, t, interval, control);
    outp(i, 1)=temp(1);
    outp(i,2)=temp(2);
    outp(i,3)=temp(3);
    interval=interval+increment;
end
outp(res,1)=control(n,1);
outp(res,2)=control(n,2);
outp(res,3)=control(n,3);
end    
    
    
    
    
    