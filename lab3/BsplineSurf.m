%n-1 контрольных точек по каждой оси
NI = 6;
NJ = 6;

%контрольные точки
%по значениям гуляет только Z, XY как сетка
[inpX,inpY] = meshgrid(0:1:NI,0:1:NJ);
% рандомим Z для задающей сетки
%степени+1 в каждом направлении
TI = 6;
TJ = 6;

%количество точек для построения по каждой оси
RESOLUTIONI = 50;
RESOLUTIONJ = 50;

%___________________________________________________________________
%
%ДАЛЕЕ НЕ ПРАВИТЬ
%___________________________________________________________________

%затравка для узловых векторов
knotsI=[];
knotsJ=[];

%всякая ерунда для циклов
i=0;j=0;ki=0;kj=0;
intervalI=0;incrementI=0;
intervalJ=0;incrementJ=0;
bi=0;bj=0;
%_______________ВСТАВИТЬ_______________________
% Step size along the curve
incrementI = (NI - TI + 2) / (RESOLUTIONI - 1);
incrementJ = (NJ - TJ + 2) / (RESOLUTIONJ - 1);

%    Calculate the knots
knotsI=SplineKnots(knotsI,NI,TI);
knotsJ=SplineKnots(knotsJ,NJ,TJ);

intervalI = 0;
    
for i=1:1:RESOLUTIONI-1
    intervalJ = 0;
    for j=1:1:RESOLUTIONJ-1
        outpX(j,i)=0;
        outpY(j,i)=0;
        outpZ(j,i) = 0;
        for ki=1:1:NI+1
            for kj=1:1:NJ+1
                bi = SplineBlend(ki,TI,knotsI,intervalI);
                bj = SplineBlend(kj,TJ,knotsJ,intervalJ);
                outpX(j,i) = outpX(j,i)+(inpX(kj, ki) * bi * bj);
                outpY(j,i) = outpY(j,i)+(inpY(kj, ki) * bi * bj);
                outpZ(j,i) = outpZ(j,i)+(inpZ(kj, ki) * bi * bj);
            end
        end
        intervalJ = intervalJ + incrementJ;
    end
    intervalI = intervalI + incrementI;
end 

  intervalI = 0;
   for i=1:1:RESOLUTIONI-1 
      outpX(RESOLUTIONJ,i) = 0;
      outpY(RESOLUTIONJ,i) = 0;
      outpZ(RESOLUTIONJ,i) = 0;
      for ki=1:1:NI+1 
          bi = SplineBlend(ki,TI,knotsI,intervalI);
          outpX(RESOLUTIONJ,i) = outpX(RESOLUTIONJ,i) + (inpX(NJ+1, ki) * bi);
          outpY(RESOLUTIONJ,i) = outpY(RESOLUTIONJ,i) + (inpY(NJ+1, ki) * bi);
          outpZ(RESOLUTIONJ,i) = outpZ(RESOLUTIONJ,i) + (inpZ(NJ+1, ki) * bi);
      end
      intervalI = intervalI +incrementI;
   end
   %???
   outpX(RESOLUTIONJ,RESOLUTIONI) = inpX(NJ+1, NI+1);
   outpY(RESOLUTIONJ,RESOLUTIONI) = inpY(NJ+1, NI+1);
   outpZ(RESOLUTIONJ,RESOLUTIONI) = inpZ(NJ+1, NI+1);
   %???

    intervalJ = 0;   
   for j=1:1:RESOLUTIONJ-1 
      outpX(j, RESOLUTIONI) = 0;
      outpY(j, RESOLUTIONI) = 0;
      outpZ(j, RESOLUTIONI) = 0;
      for kj=1:1:NJ+1 
          bj = SplineBlend(kj,TJ,knotsJ,intervalJ);
          outpX(j, RESOLUTIONI) = outpX(j, RESOLUTIONI) + (inpX(kj, NI+1) * bj);
          outpY(j, RESOLUTIONI) = outpY(j, RESOLUTIONI) + (inpY(kj, NI+1) * bj);
          outpZ(j, RESOLUTIONI) = outpZ(j, RESOLUTIONI) + (inpZ(kj, NI+1) * bj);
      end
      intervalJ = intervalJ +incrementJ;
   end
%???
outpX(j+1, RESOLUTIONI) = inpX(NJ+1, NI+1);
outpY(j+1, RESOLUTIONI) = inpY(NJ+1, NI+1);
outpZ(j+1, RESOLUTIONI) = inpZ(NJ+1, NI+1);
%???
%___________________________________НЕ ВСТАВИТЬ________________
%______________________________________________________________________
%
%ВЫБОР ВИДА ОТРИСОВКИ
%______________________________________________________________________

% контрольные точки сеткой
% mesh(inpX, inpY, inpZ,'EdgeColor', 'k', 'FaceColor', 'none')
% hold on
% surface(outpX, outpY, outpZ, 'EdgeColor', 'none')

%контрольные точки точками
plot3(inpX,inpY,inpZ, 'ko')
hold on
surface(outpX, outpY, outpZ)
