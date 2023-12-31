/* tslint:disable */
/* eslint-disable */
import { FileModel } from '../models/file-model';
export interface ProductModel {
  contentBody?: string | null;
  contentHeader?: string | null;
  filess?: Array<FileModel> | null;
  isPromote?: boolean;
  isVegan?: boolean;
  price?: number;
  productGroupId?: number;
  productGroupName?: string | null;
  productId?: number;
  productName?: string | null;
  size?: string | null;
  unit?: number;
}
