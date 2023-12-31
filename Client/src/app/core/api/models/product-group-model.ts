/* tslint:disable */
/* eslint-disable */
import { ProductModel } from '../models/product-model';
export interface ProductGroupModel {
  productGroupDescription?: string | null;
  productGroupId?: number;
  productGroupName?: string | null;
  products?: Array<ProductModel> | null;
}
