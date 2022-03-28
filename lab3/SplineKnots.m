%НЕ ТРОЖЬ
% The positions of the subintervals of v and breakpoints, the position
%    on the curve are called knots. Breakpoints can be uniformly defined
%    by setting u[j] = j, a more useful series of breakpoints are defined
%    by the function below. This set of breakpoints localises changes to
%    the vicinity of the control point being modified.
function [u] = SplineKnots(u, n, t)
%n = контрольны точки - 1, t = степень+1
for j=1:1:n+t+1
    if (j <= t)
        u(j) = 0;
    else
        if (j <= n+1)
            u(j) = j - t;
        else
            if (j > n+1)
                u(j) = n - t + 2;
            end
        end
    end
end
end