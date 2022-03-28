% This returns the point "output" on the spline curve.
% The parameter "v" indicates the position
function [outp] = SplinePoint (u, n, t, v, control)
outp = [0, 0, 0];
for k=1:1:n+1
    b=SplineBlend(k, t, u, v);
    output(1) = control(k, 1)*b;
    output(2) = control(k, 2)*b;
    output(3) = control(k, 3)*b;
end
end