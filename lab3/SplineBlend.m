%НЕ ТРОЖЬ
%Calculate the blending value, this is done recursively.
function [value] = SplineBlend (k, t, u, position)
%если на вход нормальное k и t=степень+1, то работает
value=0;
if (t==1)
    if ((u(k)<=position) && (position<u(k+1)))
        value =1;
    else
        value =0;
    end
else
    if ((u(k+t-1)==u(k))&&(u(k+t)==u(k+1)))
        value =0;
    else
        if (u(k+t-1)==u(k))
            value=(u(k+t) - position) / (u(k+t) - u(k+1)) * SplineBlend(k+1,t-1,u,position);
        else
            if (u(k+t) == u(k+1))
                value = (position - u(k)) / (u(k+t-1) - u(k)) * SplineBlend(k,t-1,u,position);
            else
                value = (position - u(k)) / (u(k+t-1) - u(k)) * SplineBlend(k,t-1,u,position) +(u(k+t) - position) / (u(k+t) - u(k+1)) * SplineBlend(k+1,t-1,u,position);
            end
        end
    end
end
end